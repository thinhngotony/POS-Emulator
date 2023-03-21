using Microsoft.VisualBasic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Vjp.Saturn1000LaneIF.Main;

namespace Vjp.Saturn1000LaneIF.Test
{
    public partial class MessageForm : Form
    {
        public static string txtposTranNum;
        public static Serial serial = null;
        private delegate void SafeCallDelegate(string text);
        //new attribute
        List<string> listBranch = new List<string>();
        int seletedRow = 0;
        int countRequest = 0;
        string logFilePath = "";
        string JsonFolderPath = "Json";
        string scenarioPath = "";
        string copyData = "";
        FileSystemWatcher w = new FileSystemWatcher();
        //end new attribute

        public MessageForm()
        {
            InitializeComponent();
            //init checkbox
            ckbAuto.Checked = true;
            ckbAutoReplace.Checked = true;
            ckbAutoPosTranNum.Checked = true;
            //init request, response
            listBranch = getAllFolderNameInFolder(JsonFolderPath);
            cbbBranch.DataSource = listBranch;
            updateAllChillComboBox(listBranch[0]);
            //init scenario
            scenarioPath = "Scenario";
            cbbTypeSce.DataSource = getAllFolderNameInFolder(scenarioPath);
            updateNextComboBox(cbbScenario);
            LoadScenario();
            watchLogFile(File.ReadAllText("Common/SourcePath.ini").Replace("\r\n", "") + @"\Log");
            dgvResPon.AutoGenerateColumns = false;

        }

        public void showMessage(string msg)
        {
            // https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-make-thread-safe-calls-to-windows-forms-controls?view=netframeworkdesktop-4.8
            if (txtReceiveMessage.InvokeRequired)
            {
                var d = new SafeCallDelegate(showMessage);
                txtReceiveMessage.Invoke(d, new object[] { msg });
            }
            else
            {
                txtReceiveMessage.Text = msg + Environment.NewLine + countRequest++.ToString();
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            serial.SendMsg(txtSendMessage.Text);
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (serial == null) serial = new Serial();
            serial.SetCallback(showMessage);
            if (!serial.isPortConnected)
            {
                serial.OpenSerialPort();
                lbSerialPort.Text = "Serial Port: " + serial.PortName;
                lbBaudRate.Text = "Baud Rate: " + serial.BauRate.ToString();
                lbParity.Text = "Parity: " + serial.GetParity().ToString();
                if (serial.isPortConnected)
                {
                    btnStartStop.Text = "Stop";
                    btnSend.Enabled = true;
                }
            }
            else
            {
                serial.CloseSerialPort();
                btnStartStop.Text = "Start";
                btnSend.Enabled = false;
            }
        }

        private bool checkMouseReceive = true;

        private void txtReceiveMessage_Click(object sender, EventArgs e)
        {
            if (checkMouseReceive)
            {
                txtReceiveMessage.SelectAll();
                checkMouseReceive = false;
            }
        }

        private void txtReceiveMessage_MouseLeave(object sender, EventArgs e)
        {
            checkMouseReceive = true;
        }

        private bool checkMouseSend = true;

        private void txtSendMessage_Click(object sender, EventArgs e)
        {
            if (checkMouseSend)
            {
                txtSendMessage.SelectAll();
                checkMouseSend = false;
            }
        }

        private void txtSendMessage_MouseLeave(object sender, EventArgs e)
        {
            checkMouseSend = true;
        }

        //catch file change and assign the path to logFilePath
        private void W_Changed(object sender, FileSystemEventArgs e)
        {
            logFilePath = e.FullPath;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox currentCheck = sender as CheckBox;
            if (currentCheck.Checked == true)
            {
                if (currentCheck == ckbAuto)
                {
                    ckbManual.Checked = false;
                }
                else
                {
                    ckbAuto.Checked = false;
                }
            }
        }

        private void txtReceiveMessage_TextChanged(object sender, EventArgs e)
        {
            //get service, biz, outputID
            string service = "";
            string biz = "";
            txtposTranNum = "";
            foreach (string line in txtReceiveMessage.Lines)
            {
                if (line.Contains("outputId") || line.Contains("trSumId"))
                {
                    if (!ckbLockOutID.Checked)
                        txtOldOutputID.Text = txtOutputID.Text;
                    txtOutputID.Text = line.Split(':')[1].Trim().Replace("\"", "").Replace(",", "");
                }
                if (line.Contains("posTranNum"))
                {
                    txtposTranNum = getJsonValueByLine(line);
                }
                if (line.Contains("service"))
                {
                    service = getJsonValueByLine(line);
                }
                if (line.Contains("biz"))
                {
                    biz = getJsonValueByLine(line);
                }
                if (line.Contains("seqNo"))
                {
                    txtSeqNo.Text = getJsonValueByLine(line);
                }
            }

            //auto response
            if (ckbAuto.Checked == true)
            {
                bool matchRequest = false;
                foreach (DataGridViewRow row in dgvResPon.Rows)
                {
                    try
                    {
                        string requestPath = getPath("Request", row.Cells[0].Value.ToString());
                        if (isMatchRequest(requestPath, service, biz))
                        {
                            string responsePath = getPath("Response", row.Cells[1].Value.ToString());
                            string requestFile = requestPath.Split(Path.AltDirectorySeparatorChar)[3];
                            string responseFile = responsePath.Split(Path.AltDirectorySeparatorChar)[3];
                            txtNotify.AppendText(requestFile + " => " + responseFile + Environment.NewLine);
                            txtSendMessage.Text = File.ReadAllText(responsePath);
                            if (ckbAutoReplace.Checked)
                                setOutputID(txtOutputID.Text);
                            serial.SendMsg(txtSendMessage.Text);
                            Thread.Sleep(Int32.Parse(txtSleep.Text));
                            matchRequest = true;
                        }
                    }
                    catch (Exception) { }
                }
                if (!matchRequest)
                    foreach (var item in cbbRequest.Items)
                    {
                        try
                        {
                            string requestPath = getPath("Request", item.ToString());
                            if (isMatchRequest(requestPath, service, biz))
                            {
                                txtNotify.AppendText("receive " + item.ToString() + " request" + Environment.NewLine);
                                matchRequest = true;
                            }
                        }
                        catch (Exception) { }
                    }

                if (!matchRequest)
                {
                    txtNotify.AppendText("no " + cbbBranch.Text + " request found" + Environment.NewLine);
                }
            }

            //auto replace outputID
            if (ckbAutoReplace.Checked)
                setOutputID(txtOutputID.Text);

            if (ckbHealthCheck.Checked)
            {
                if (service == "3000001")
                    if (biz == "1")
                    {
                        txtSendMessage.Text = File.ReadAllText("Json/HealthCheck/HealthCheckOK/ResponseHealthCheckOK.json");
                        setOutputID(txtOutputID.Text);
                        serial.SendMsg(txtSendMessage.Text);
                    }
            }

        }

        private void btnDelID_Click(object sender, EventArgs e)
        {
            setOutputID("");
        }

        private void txtSendMessage_MouseUp(object sender, MouseEventArgs e)
        {
            if (ckbAutoReplace.Checked)
                setOutputID(txtOutputID.Text);
            if (ckbAutoPosTranNum.Checked)
                setPosTranNum(txtposTranNum);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvResPon.Rows.Add(cbbRequest.Text, cbbResponse.Text);
            dgvResPon.Update();
            dgvResPon.Refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                dgvResPon.SelectedRows[seletedRow].Cells[0].Value = cbbRequest.Text;
                dgvResPon.SelectedRows[seletedRow].Cells[1].Value = cbbResponse.Text;
            }
            catch (Exception) { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvResPon.SelectedRows)
                {
                    dgvResPon.Rows.RemoveAt(row.Index);
                }
            }
            catch (Exception) { }
        }

        private void cbbBranch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                updateAllChillComboBox(cbbBranch.Text);
            }
        }

        private void cbbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateAllChillComboBox(cbbBranch.Text);
        }

        private void dgvResPon_SelectionChanged(object sender, EventArgs e)
        {
            seletedRow = dgvResPon.SelectedRows.Count - 1;
            try
            {
                string cell0 = dgvResPon.SelectedRows[seletedRow].Cells[0].Value.ToString();
                string cell1 = dgvResPon.SelectedRows[seletedRow].Cells[1].Value.ToString();
                cbbRequest.Text = cell0;
                cbbResponse.Text = cell1;
            }
            catch (Exception) { }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string path = getPath(cbbResponse);
            try
            {
                copyData = File.ReadAllText(path);
                Clipboard.SetText(copyData);
                txtNotify.AppendText("Copy:  " + cbbResponse.Text.Replace(".txt", "") + Environment.NewLine);
            }
            catch (Exception ex)
            {
                txtNotify.AppendText("Not found file   " + path + Environment.NewLine);
                MessageBox.Show(ex.ToString());
            }


        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            txtSendMessage.Text = copyData;
            setOutputID(txtOutputID.Text);
            setPosTranNum(txtposTranNum);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNotify.Text = "";
        }

        private void cbbTypeSce_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                updateNextComboBox(cbbScenario);
                LoadScenario();
            }
        }

        private void cbbTypeSce_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateNextComboBox(cbbScenario);
            LoadScenario();
        }

        private void cbbScenario_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadScenario();
        }

        private void cbbScenario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadScenario();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Input file name", "Name", "", (Left + Right) / 2, (Top + Bottom) / 2);
            if (input != "")
            {
                string path = input.Replace(".txt", "") + ".txt";
                string fullPath = scenarioPath + @"\" + cbbTypeSce.Text + @"\" + path;
                if (File.Exists(fullPath))
                {
                    var result = MessageBox.Show("file Exists, do you want to replace!", "error", MessageBoxButtons.YesNo);
                    if (result != DialogResult.Yes)
                        return;
                    else
                    {
                        File.Delete(fullPath);
                    }
                }
                using (StreamWriter file = new StreamWriter(fullPath, append: true))
                {
                    foreach (DataGridViewRow row in dgvResPon.Rows)
                    {
                        try
                        {
                            file.WriteLine(row.Cells[0].Value.ToString() + "," + row.Cells[1].Value.ToString());
                        }
                        catch (Exception) { }
                    }
                }

            }

        }

        private void btnClearScreen_Click(object sender, EventArgs e)
        {
            txtLoadScreen.Text = "";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtLoadScreen.Text = "";
            try
            {
                string[] logLines = File.ReadAllLines(logFilePath);
                List<string> loadScreens = new List<string>();
                foreach (string line in logLines)
                {
                    if (line.Contains("Load screen"))
                    {
                        loadScreens.Add(line.Split('|')[3].Replace("Msg: Load screen", ""));
                    }
                }
                string[] ArrLoadScreen = loadScreens.ToArray();
                int length = ArrLoadScreen.Length;
                int lineShow = Int32.Parse(txtLineCount.Text);
                int start = 0;
                if (lineShow < length)
                    start = length - lineShow;
                for (int i = start; i < length; i++)
                {
                    txtLoadScreen.AppendText(ArrLoadScreen[i] + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                txtLoadScreen.AppendText("Not found log file" + Environment.NewLine);
                txtLoadScreen.AppendText("Check SourcePath.ini file");
                MessageBox.Show(ex.ToString());
            }
        }

        private List<string> getAllFileNameInFolder(string path)
        {
            string[] files = Directory.GetFiles(path);
            int len = files.Length;
            for (int i = 0; i < len; i++)
            {
                files[i] = Path.GetFileName(files[i]);
            }
            return new List<string>(files);
        }

        private List<string> getAllFolderNameInFolder(string path)
        {
            try
            {
                string[] folder = Directory.GetDirectories(path);
                int len = folder.Length;
                for (int i = 0; i < len; i++)
                {
                    folder[i] = Path.GetFileName(folder[i]);
                }
                return new List<string>(folder);
            } catch (Exception e)
            {
                //MessageBox.Show(e.ToString());  
                return null;
            }

        }

        private string getJsonValueByLine(string line)
        {
            string term = line.Split(':')[1];
            term = term.Replace(" ", "");
            term = term.Replace(",", "");
            term = term.Replace("\"", "");
            return term;
        }

        private bool isMatchRequest(string path, string service, string biz)
        {
            string[] lines = File.ReadAllLines(path);
            string service2 = "";
            string biz2 = "";
            int length = lines.Length;
            for (int i = 0; i < length; i++)
            {
                if (lines[i].Contains("service"))
                {
                    service2 = getJsonValueByLine(lines[i]);

                }
                if (lines[i].Contains("biz"))
                {
                    biz2 = getJsonValueByLine(lines[i]);
                }
            }
            if (service2 == service && biz2 == biz)
                return true;
            return false;
        }

        private void setOutputID(string outputID)
        {
            try
            {
                JObject json = JObject.Parse(txtSendMessage.Text);
                JObject token = json["controlInfo"] as JObject;
                if (token.HasValues && token.ContainsKey("outputId"))
                    json["controlInfo"]["outputId"] = outputID;
                txtSendMessage.Text = json.ToString();
            }
            catch (JsonReaderException ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        private void setPosTranNum(string posTranNum)
        {
            try
            {
                JObject json = JObject.Parse(txtSendMessage.Text);
                JObject token = json["bizInfo"] as JObject;
                if (token.HasValues && token.ContainsKey("posTranNum"))
                    json["bizInfo"]["posTranNum"] = posTranNum;
                txtSendMessage.Text = json.ToString();
            }
            catch (JsonReaderException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void watchLogFile(string path)
        {
            w.Path = path;
            w.NotifyFilter = NotifyFilters.LastWrite;
            w.Filter = "*.log";
            w.Changed += new FileSystemEventHandler(W_Changed);
            w.EnableRaisingEvents = true;
        }

        private void LoadScenario()
        {
            try
            {
                dgvResPon.Rows.Clear();
                string[] lines = File.ReadAllLines(this.scenarioPath + @"\" + cbbTypeSce.Text + @"\" + cbbScenario.Text);
                foreach (string line in lines)
                {
                    string[] splitData = line.Split(',');
                    dgvResPon.Rows.Add(splitData[0], splitData[1]);
                    dgvResPon.Update();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        private void updateAllChillComboBox(string branch)
        {
            try
            {
                string requestPath = JsonFolderPath + @"\" + branch + @"\Request";
                string ResponsePath = JsonFolderPath + @"\" + branch + @"\Response";
                cbbRequest.Text = "";
                List<string> temp = getAllFileNameInFolder(requestPath);
                int len = temp.Count;
                for (int i = 0; i < len; i++)
                {
                    temp[i] = cbbBranch.Text + "/" + temp[i];
                }
                cbbRequest.DataSource = temp;
                cbbResponse.Text = "";
                temp = getAllFileNameInFolder(ResponsePath);
                len = temp.Count;
                for (int i = 0; i < len; i++)
                {
                    temp[i] = cbbBranch.Text + "/" + temp[i];
                }
                cbbResponse.DataSource = temp;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        private void updateNextComboBox(ComboBox cbb)
        {
            try
            {
                string ScenarioPath = this.scenarioPath + @"\" + cbbTypeSce.Text;
                cbb.Text = "";
                cbb.DataSource = getAllFileNameInFolder(ScenarioPath);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        private string getPath(ComboBox cb)
        {
            string[] text = cb.Text.Split(Path.AltDirectorySeparatorChar);
            if (cb == cbbRequest)
            {
                return JsonFolderPath + @"/" + text[0] + @"/Request/" + text[1];
            }
            else if (cb == cbbResponse)
            {
                return JsonFolderPath + @"/" + text[0] + @"/Response/" + text[1];
            }
            return null;
        }

        private string getPath(string type, string path)
        {
            string[] text = path.Split(Path.AltDirectorySeparatorChar);
            if (type == "Request")
            {
                return JsonFolderPath + @"/" + text[0] + @"/Request/" + text[1];
            }
            else if (type == "Response")
            {
                return JsonFolderPath + @"/" + text[0] + @"/Response/" + text[1];
            }
            return null;
        }

        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(String lpClassName, String lpWindowName);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);

        private void btnOpenReset_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("deleteAllFile");
            if (processes.Length == 0)
            {
                Process.Start("deleteAllFile.exe");
            }
            else
            {
                IntPtr handle = FindWindow(null, "Reset all file in Emoney");
                if (handle == IntPtr.Zero)
                {
                    return;
                }
                ShowWindow(handle, 1);
            }

        }
    }
}

namespace Vjp.Saturn1000LaneIF.Test
{
    partial class MessageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReceiveMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSendMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbParity = new System.Windows.Forms.Label();
            this.lbBaudRate = new System.Windows.Forms.Label();
            this.lbSerialPort = new System.Windows.Forms.Label();
            this.ckbManual = new System.Windows.Forms.CheckBox();
            this.ckbAuto = new System.Windows.Forms.CheckBox();
            this.dgvResPon = new System.Windows.Forms.DataGridView();
            this.Request = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Response = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNotify = new System.Windows.Forms.TextBox();
            this.cbbResponse = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbbScenario = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ckbAutoReplace = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtOutputID = new System.Windows.Forms.TextBox();
            this.txtSleep = new System.Windows.Forms.TextBox();
            this.btnDelID = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtLoadScreen = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtLineCount = new System.Windows.Forms.TextBox();
            this.cbbRequest = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbTypeSce = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbBranch = new System.Windows.Forms.ComboBox();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtOldOutputID = new System.Windows.Forms.TextBox();
            this.ckbLockOutID = new System.Windows.Forms.CheckBox();
            this.txtSeqNo = new System.Windows.Forms.TextBox();
            this.btnOpenReset = new System.Windows.Forms.Button();
            this.ckbHealthCheck = new System.Windows.Forms.CheckBox();
            this.ckbAutoPosTranNum = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResPon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtReceiveMessage
            // 
            this.txtReceiveMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtReceiveMessage, "txtReceiveMessage");
            this.txtReceiveMessage.Name = "txtReceiveMessage";
            this.txtReceiveMessage.ReadOnly = true;
            this.txtReceiveMessage.Click += new System.EventHandler(this.txtReceiveMessage_Click);
            this.txtReceiveMessage.TextChanged += new System.EventHandler(this.txtReceiveMessage_TextChanged);
            this.txtReceiveMessage.MouseLeave += new System.EventHandler(this.txtReceiveMessage_MouseLeave);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtSendMessage
            // 
            this.txtSendMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtSendMessage, "txtSendMessage");
            this.txtSendMessage.Name = "txtSendMessage";
            this.txtSendMessage.Click += new System.EventHandler(this.txtSendMessage_Click);
            this.txtSendMessage.MouseLeave += new System.EventHandler(this.txtSendMessage_MouseLeave);
            this.txtSendMessage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtSendMessage_MouseUp);
            // 
            // btnSend
            // 
            resources.ApplyResources(this.btnSend, "btnSend");
            this.btnSend.Name = "btnSend";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // btnStartStop
            // 
            resources.ApplyResources(this.btnStartStop, "btnStartStop");
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbParity);
            this.groupBox1.Controls.Add(this.lbBaudRate);
            this.groupBox1.Controls.Add(this.lbSerialPort);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lbParity
            // 
            resources.ApplyResources(this.lbParity, "lbParity");
            this.lbParity.Name = "lbParity";
            // 
            // lbBaudRate
            // 
            resources.ApplyResources(this.lbBaudRate, "lbBaudRate");
            this.lbBaudRate.Name = "lbBaudRate";
            // 
            // lbSerialPort
            // 
            resources.ApplyResources(this.lbSerialPort, "lbSerialPort");
            this.lbSerialPort.Name = "lbSerialPort";
            // 
            // ckbManual
            // 
            resources.ApplyResources(this.ckbManual, "ckbManual");
            this.ckbManual.Name = "ckbManual";
            this.ckbManual.UseVisualStyleBackColor = true;
            this.ckbManual.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // ckbAuto
            // 
            resources.ApplyResources(this.ckbAuto, "ckbAuto");
            this.ckbAuto.Name = "ckbAuto";
            this.ckbAuto.UseVisualStyleBackColor = true;
            this.ckbAuto.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // dgvResPon
            // 
            this.dgvResPon.AllowUserToAddRows = false;
            this.dgvResPon.AllowUserToDeleteRows = false;
            this.dgvResPon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResPon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvResPon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResPon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Request,
            this.Response});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResPon.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.dgvResPon, "dgvResPon");
            this.dgvResPon.Name = "dgvResPon";
            this.dgvResPon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResPon.SelectionChanged += new System.EventHandler(this.dgvResPon_SelectionChanged);
            // 
            // Request
            // 
            resources.ApplyResources(this.Request, "Request");
            this.Request.Name = "Request";
            this.Request.ReadOnly = true;
            // 
            // Response
            // 
            resources.ApplyResources(this.Response, "Response");
            this.Response.Name = "Response";
            this.Response.ReadOnly = true;
            // 
            // txtNotify
            // 
            resources.ApplyResources(this.txtNotify, "txtNotify");
            this.txtNotify.Name = "txtNotify";
            // 
            // cbbResponse
            // 
            this.cbbResponse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbResponse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.cbbResponse, "cbbResponse");
            this.cbbResponse.FormattingEnabled = true;
            this.cbbResponse.Name = "cbbResponse";
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbbScenario
            // 
            this.cbbScenario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbScenario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.cbbScenario, "cbbScenario");
            this.cbbScenario.FormattingEnabled = true;
            this.cbbScenario.Name = "cbbScenario";
            this.cbbScenario.SelectedIndexChanged += new System.EventHandler(this.cbbScenario_SelectedIndexChanged);
            this.cbbScenario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbScenario_KeyDown);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ckbAutoReplace
            // 
            resources.ApplyResources(this.ckbAutoReplace, "ckbAutoReplace");
            this.ckbAutoReplace.Name = "ckbAutoReplace";
            this.ckbAutoReplace.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtOutputID
            // 
            resources.ApplyResources(this.txtOutputID, "txtOutputID");
            this.txtOutputID.Name = "txtOutputID";
            // 
            // txtSleep
            // 
            resources.ApplyResources(this.txtSleep, "txtSleep");
            this.txtSleep.Name = "txtSleep";
            // 
            // btnDelID
            // 
            resources.ApplyResources(this.btnDelID, "btnDelID");
            this.btnDelID.Name = "btnDelID";
            this.btnDelID.UseVisualStyleBackColor = true;
            this.btnDelID.Click += new System.EventHandler(this.btnDelID_Click);
            // 
            // btnCopy
            // 
            resources.ApplyResources(this.btnCopy, "btnCopy");
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtLoadScreen
            // 
            resources.ApplyResources(this.txtLoadScreen, "txtLoadScreen");
            this.txtLoadScreen.Name = "txtLoadScreen";
            // 
            // btnShow
            // 
            resources.ApplyResources(this.btnShow, "btnShow");
            this.btnShow.Name = "btnShow";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtLineCount
            // 
            resources.ApplyResources(this.txtLineCount, "txtLineCount");
            this.txtLineCount.Name = "txtLineCount";
            // 
            // cbbRequest
            // 
            this.cbbRequest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbRequest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.cbbRequest, "cbbRequest");
            this.cbbRequest.FormattingEnabled = true;
            this.cbbRequest.Name = "cbbRequest";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // cbbTypeSce
            // 
            this.cbbTypeSce.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbTypeSce.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.cbbTypeSce, "cbbTypeSce");
            this.cbbTypeSce.FormattingEnabled = true;
            this.cbbTypeSce.Name = "cbbTypeSce";
            this.cbbTypeSce.SelectedIndexChanged += new System.EventHandler(this.cbbTypeSce_SelectedIndexChanged);
            this.cbbTypeSce.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbTypeSce_KeyDown);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // cbbBranch
            // 
            this.cbbBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.cbbBranch, "cbbBranch");
            this.cbbBranch.FormattingEnabled = true;
            this.cbbBranch.Name = "cbbBranch";
            this.cbbBranch.SelectedIndexChanged += new System.EventHandler(this.cbbBranch_SelectedIndexChanged);
            this.cbbBranch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbBranch_KeyDown);
            // 
            // btnPaste
            // 
            resources.ApplyResources(this.btnPaste, "btnPaste");
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnNew
            // 
            resources.ApplyResources(this.btnNew, "btnNew");
            this.btnNew.Name = "btnNew";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtOldOutputID
            // 
            resources.ApplyResources(this.txtOldOutputID, "txtOldOutputID");
            this.txtOldOutputID.Name = "txtOldOutputID";
            // 
            // ckbLockOutID
            // 
            resources.ApplyResources(this.ckbLockOutID, "ckbLockOutID");
            this.ckbLockOutID.Name = "ckbLockOutID";
            this.ckbLockOutID.UseVisualStyleBackColor = true;
            // 
            // txtSeqNo
            // 
            resources.ApplyResources(this.txtSeqNo, "txtSeqNo");
            this.txtSeqNo.Name = "txtSeqNo";
            // 
            // btnOpenReset
            // 
            resources.ApplyResources(this.btnOpenReset, "btnOpenReset");
            this.btnOpenReset.Name = "btnOpenReset";
            this.btnOpenReset.UseVisualStyleBackColor = true;
            this.btnOpenReset.Click += new System.EventHandler(this.btnOpenReset_Click);
            // 
            // ckbHealthCheck
            // 
            resources.ApplyResources(this.ckbHealthCheck, "ckbHealthCheck");
            this.ckbHealthCheck.Checked = true;
            this.ckbHealthCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbHealthCheck.Name = "ckbHealthCheck";
            this.ckbHealthCheck.UseVisualStyleBackColor = true;
            // 
            // ckbAutoPosTranNum
            // 
            resources.ApplyResources(this.ckbAutoPosTranNum, "ckbAutoPosTranNum");
            this.ckbAutoPosTranNum.Name = "ckbAutoPosTranNum";
            this.ckbAutoPosTranNum.UseVisualStyleBackColor = true;
            // 
            // MessageForm
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ckbAutoPosTranNum);
            this.Controls.Add(this.ckbHealthCheck);
            this.Controls.Add(this.btnOpenReset);
            this.Controls.Add(this.txtSeqNo);
            this.Controls.Add(this.ckbLockOutID);
            this.Controls.Add(this.txtOldOutputID);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.cbbBranch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbTypeSce);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbRequest);
            this.Controls.Add(this.txtLineCount);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtLoadScreen);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnDelID);
            this.Controls.Add(this.txtSleep);
            this.Controls.Add(this.txtOutputID);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ckbAutoReplace);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbbScenario);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbbResponse);
            this.Controls.Add(this.txtNotify);
            this.Controls.Add(this.dgvResPon);
            this.Controls.Add(this.ckbManual);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ckbAuto);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSendMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReceiveMessage);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MessageForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResPon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtReceiveMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSendMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbSerialPort;
        private System.Windows.Forms.Label lbBaudRate;
        private System.Windows.Forms.Label lbParity;
        private System.Windows.Forms.CheckBox ckbManual;
        private System.Windows.Forms.CheckBox ckbAuto;
        private System.Windows.Forms.DataGridView dgvResPon;
        private System.Windows.Forms.TextBox txtNotify;
        private System.Windows.Forms.ComboBox cbbResponse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Request;
        private System.Windows.Forms.DataGridViewTextBoxColumn Response;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbbScenario;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox ckbAutoReplace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtOutputID;
        private System.Windows.Forms.TextBox txtSleep;
        private System.Windows.Forms.Button btnDelID;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox txtLoadScreen;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtLineCount;
        private System.Windows.Forms.ComboBox cbbRequest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbTypeSce;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbBranch;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtOldOutputID;
        private System.Windows.Forms.CheckBox ckbLockOutID;
        private System.Windows.Forms.TextBox txtSeqNo;
        private System.Windows.Forms.Button btnOpenReset;
        private System.Windows.Forms.CheckBox ckbHealthCheck;
        private System.Windows.Forms.CheckBox ckbAutoPosTranNum;
    }
}


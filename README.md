This C# project provides the functionality to send and receive messages through a serial port. It also allows for automatic responses based on the content of the received messages.

## Attributes

- `txtposTranNum`: a string that holds the transaction number.
- `serial`: a `Serial` object that handles the communication through the serial port.
- `listBranch`: a list of strings that holds the names of all folders within the "Json" directory.
- `seletedRow`: an integer that holds the index of the currently selected row in the user interface.
- `countRequest`: an integer that holds the number of requests made.
- `logFilePath`: a string that holds the path to the log file.
- `JsonFolderPath`: a string that holds the path to the "Json" directory.
- `scenarioPath`: a string that holds the path to the "Scenario" directory.
- `copyData`: a string that holds the data to be copied.
- `w`: a `FileSystemWatcher` object that watches for changes in a file.

## Methods

- `showMessage(string msg)`: displays a message in the user interface.
- `buttonSend_Click(object sender, EventArgs e)`: sends a message through the serial port.
- `btnStartStop_Click(object sender, EventArgs e)`: starts or stops the serial port.
- `txtReceiveMessage_Click(object sender, EventArgs e)`: selects all the text in the "Receive Message" text box.
- `txtReceiveMessage_MouseLeave(object sender, EventArgs e)`: resets the mouse selection flag.
- `txtSendMessage_Click(object sender, EventArgs e)`: selects all the text in the "Send Message" text box.
- `txtSendMessage_MouseLeave(object sender, EventArgs e)`: resets the mouse selection flag.
- `W_Changed(object sender, FileSystemEventArgs e)`: stores the path to the log file.
- `checkBox_CheckedChanged(object sender, EventArgs e)`: updates the check boxes in the user interface.
- `txtReceiveMessage_TextChanged(object sender, EventArgs e)`: reads the content of the "Receive Message" text box and performs actions based on its content.
- `btnDelID_Click(object sender, EventArgs e)`: clears the output ID.
- `txtSendMessage_MouseUp(object sender, MouseEventArgs e)`: updates the output ID and transaction number.

## Constructor

- `MessageForm()`: initializes the user interface and the class attributes.
using System;
using System.Windows.Forms;
using ZigBee;
using ZigBeeLib;

namespace RVSLite{
    public class TerminalController{
        private readonly Button _btnConnect;
        private readonly Button _btnSendATCommand;
        private readonly TelegesisETRX2Communicator _communicator;
        private readonly Form _form;
        private readonly TextBox _txtATCommand;
        private readonly TextBox _txtTerminal;

        public TerminalController(Form form, Button btnConnect, Button btnSendATCommand, TextBox txtATCommand,
                                  TextBox txtTerminal){
            _form = form;
            _btnConnect = btnConnect;
            _btnSendATCommand = btnSendATCommand;
            _txtATCommand = txtATCommand;
            _txtTerminal = txtTerminal;
            SetStateModeTo(false);
            _communicator = new TelegesisETRX2Communicator();
            Bind();
        }

        private void Bind(){
            _communicator.OnAnswerReceived += Comm_OnAnswerReceived;
            _communicator.OnStateChanged += comm_OnStateChanged;
            _btnConnect.Click += btnConnect_Click;
            _btnSendATCommand.Click += btnSendATCommand_Click;
        }


        private void comm_OnStateChanged(TelegesisETRX2Communicator source){
            _btnConnect.Text = source.Connected ? Lang.Res.Disconnect : Lang.Res.Connect;
        }

        private void SetText(string text){
            if (_txtTerminal.InvokeRequired){
                var d = new SetTextCallback(SetText);
                _form.Invoke(d, new object[]{text});
            }
            else{
                _txtTerminal.AppendText(text);
            }
        }

        public TelegesisETRX2Communicator Communicator{
            get { return _communicator; }
        }

        public void Close(){
            _communicator.Dispose();
        }

        private void Comm_OnAnswerReceived(TelegesisETRX2Communicator source){
            string readLines = source.LastReadLines;
//            SetText(readLines);
//            StoreSData(readLines);
        }

        private void StoreSData(string readLines){
            var sData = new TelegesisETRX2SData(readLines);
            if (sData.IsUndefined)
                return;
            bool io2Pressed = (sData.IOData & 0x4) == 0;
            if (io2Pressed){
                SetText("\r\npressed\r\n");
                SetLedNIn(sData.NodeId, 4, 0);
            }
            else{
                SetText("\r\nreleased\r\n");
                SetLedNIn(sData.NodeId, 4, 1);
            }
        }

        private TelegesisETRX2SData GetSDataBy(string readLines){
            return new TelegesisETRX2SData(readLines);
        }

        private void SetLedNIn(string nodeId, int bitPos, int value){
            SentATCommand("AT", string.Format("SREM0F{1}:{0}={2}", nodeId, bitPos, value));
        }

        private void btnSendATCommand_Click(object sender, EventArgs e){
            SendAtCommand();
        }

        private void SendAtCommand(){
            SentATCommand(string.Empty, _txtATCommand.Text = _txtATCommand.Text.Trim());
        }

        private void SentATCommand(string prefix, string command){
            string atCommand = prefix + command;
            if (atCommand.Length == 0)
                return;
            _communicator.Write(atCommand);
        }

        private void btnConnect_Click(object sender, EventArgs e){
            string processDescription = string.Empty;
            try{
                if (_communicator.Connected) {
                    processDescription = Lang.Res.Disconnection_process;
                    _communicator.Disconnect();
                    SetStateModeTo(false);
                }
                else{
                    processDescription = Lang.Res.Connection_process;
                    _communicator.Connect();
                    SetStateModeTo(true);
                    _txtATCommand.Text = "ATI";
                }
            }
            catch (Exception ex){
               Messenger.ShowError(ex, processDescription);
            }
        }

        private void SetStateModeTo(bool enabled){
            _txtATCommand.Enabled = _btnSendATCommand.Enabled = enabled;
        }

        #region Nested type: SetTextCallback

        private delegate void SetTextCallback(string text);

        #endregion
    }
}
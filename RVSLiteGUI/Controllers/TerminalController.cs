using System;
using System.Windows.Forms;
using SerialConnection;

namespace RVSLite{
    public class TerminalController {
        const string NULL_PORT = "NUL";
        public event SerialConnectionEventHandler OnAnswerReceived;
        public event SerialConnectionEventHandler OnClear;
        public event SerialConnectionEventHandler OnDisconnected;

        private readonly Button _btnConnect;
        private readonly Button _btnSendMessage;
        private readonly Form _form;
        private readonly TextBox _txtMessage;
        private readonly TextBox _txtTerminal;
        private readonly ComboBox _cbSerialConnectionProviders;
        private readonly ComboBox _cbPorts;
        private readonly ComboBox _cbBaud;

        public TerminalController(Form form, Button btnConnect, Button btnSendATCommand, TextBox txtATCommand, TextBox txtTerminal, ComboBox cbSerialConnectionProviders, ComboBox cbPorts, ComboBox cbBaud){
            _form = form;
            _btnConnect = btnConnect;
            _btnSendMessage = btnSendATCommand;
            _txtMessage = txtATCommand;
            _txtTerminal = txtTerminal;
            _cbSerialConnectionProviders = cbSerialConnectionProviders;
            _cbPorts = cbPorts;
            _cbBaud = cbBaud;
            SetSelectedSerialConnectionProvider();
            ChangeControlsState(Connection);
            Bind();
        }

        private void Bind(){
            _btnConnect.Click += btnConnect_Click;
            _btnSendMessage.Click += btnSendMessage_Click;
            _cbSerialConnectionProviders.SelectionChangeCommitted += _cbSerialConnectionProviders_SelectionChangeCommitted;
        }

        void _cbSerialConnectionProviders_SelectionChangeCommitted(object sender, EventArgs e){
            SetSelectedSerialConnectionProvider();
        }

        private void SetSelectedSerialConnectionProvider(){
            if(Connection != null)
                UnBindConnection();
            if(_cbSerialConnectionProviders.SelectedIndex < 0)
                throw new Exception("No selected serial connection providers");
            Connection = (SerialConnectionBase) _cbSerialConnectionProviders.SelectedItem;
            BindConnection();
        }

        private void BindConnection(){
            Connection.OnAnswerReceived += Comm_OnAnswerReceived;
            Connection.OnStateChanged += comm_OnStateChanged;
        }

        private void UnBindConnection(){
            Connection.OnAnswerReceived -= Comm_OnAnswerReceived;
            Connection.OnStateChanged -= comm_OnStateChanged;
        }

        private void comm_OnStateChanged(SerialConnectionBase connection){
            ChangeControlsState(connection);
        }

        public SerialConnectionBase Connection { get; set; }

        public void Close(){
            Connection.Dispose();
        }

        private void Comm_OnAnswerReceived(SerialConnectionBase source){
            string readLines = source.LastReadLines;
            ControlCallback.AppendTextFor(_form, _txtTerminal, readLines);
            if (OnAnswerReceived != null)
                OnAnswerReceived(source);
        }

        private void btnSendMessage_Click(object sender, EventArgs e){
            string message = _txtMessage.Text = _txtMessage.Text.Trim();
            if (message.Length == 0)
                return;
            Connection.Write(message);
        }

        private void btnConnect_Click(object sender, EventArgs e){
            string processDescription = string.Empty;
            try{
                Cursor.Current = Cursors.WaitCursor;
                if (Connection.Connected) {
                    processDescription = Lang.Res.Disconnection_process;
                    Connection.Disconnect();
                }
                else{
                    if(GetSelectedPort() == NULL_PORT)
                        throw new Exception("No serial ports found");
                    processDescription = Lang.Res.Connection_process;
                    Connection.Port = GetSelectedPort();
                    Connection.Baud = GetSelectedBaud();
                    Connection.Connect();
                }
                _cbPorts.Enabled = _cbBaud.Enabled = !Connection.Connected;
                ChangeControlsState(Connection);
            }
            catch (Exception ex){
                Messenger.ShowError(ex, processDescription);
                try{
                    if(Connection.Connected)
                        Connection.Disconnect();
                }
                catch (Exception ex1){
                    Messenger.ShowError(ex1, Lang.Res.Error);
                }
            }
            finally{
                Cursor.Current = Cursors.Default;
            }
        }

        private void ChangeControlsState(SerialConnectionBase connection){
            bool connected = connection.Connected && connection.Ready;
            ControlCallback.SetTextFor(_form, _btnConnect, connected ? Lang.Res.Disconnect : Lang.Res.Connect);
            ControlCallback.SetEnabledFor(_form, _txtMessage, connected);
            ControlCallback.SetEnabledFor(_form, _btnSendMessage, connected);
            if (connected && OnClear != null)
                OnClear(connection);
            if (!connected && OnDisconnected != null)
                OnDisconnected(connection);
        }


        private int GetSelectedBaud() {
            return (int)_cbBaud.SelectedItem;
        }

        private string GetSelectedPort(){
            return _cbPorts.SelectedIndex == -1 ? NULL_PORT : _cbPorts.SelectedItem.ToString();
        }
    }
}
using System;
using System.IO.Ports;
using System.Text;

namespace ZigBee{
    public delegate void TelegesisETRX2EventHandler(TelegesisETRX2Communicator source);

    public class TelegesisETRX2Communicator : IDisposable{
        private readonly SerialPort _serialPort = new SerialPort();

        public TelegesisETRX2Communicator(){
            InitPortProperties("COM4", 19200);
            LastReadLines = string.Empty;
        }

        public string LastReadLines { get; private set; }

        public bool AnswerReceived { get; private set; }

        public bool Connected{
            get { return _serialPort.IsOpen; }
        }

        #region IDisposable Members

        public void Dispose(){
            Disconnect();
        }

        #endregion

        public event TelegesisETRX2EventHandler OnAnswerReceived;
        public event TelegesisETRX2EventHandler OnStateChanged;

        public void Close(){
            Dispose();
        }

        private void InitPortProperties(string portName, int baudRate){
            _serialPort.Encoding = Encoding.ASCII;
            _serialPort.DataReceived += _serialPort_DataReceived;
            _serialPort.PortName = portName;
            _serialPort.BaudRate = baudRate;
            _serialPort.Parity = Parity.None;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = StopBits.One;
            _serialPort.Handshake = Handshake.None;
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;
        }

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e){
            LastReadLines = _serialPort.ReadExisting();
            AnswerReceived = true;
            if (OnAnswerReceived != null)
                OnAnswerReceived(this);
        }

        public void WriteAT(string AT_Command_value){
            Write(string.Format("AT{0}", AT_Command_value));
        }

        public void Write(string AT_Command){
            AnswerReceived = false;
            try{
                Connect();
                _serialPort.Write(string.Format("{0}\n\r", AT_Command));
            }
            catch (Exception ex){
                Dispose();
                throw (ex);
            }
        }

        public void Connect(){
            if (Connected)
                return;
            _serialPort.Open();
            FireStatusChanged();
        }

        public void Disconnect(){
            if (!_serialPort.IsOpen)
                return;
            _serialPort.Close();
            FireStatusChanged();
        }

        private void FireStatusChanged(){
            if (OnStateChanged != null)
                OnStateChanged(this);
        }
    }
}
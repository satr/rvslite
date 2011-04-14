using System;
using System.IO.Ports;
using System.Text;

namespace SerialConnection{
    public delegate void SerialConnectionEventHandler(SerialConnectionBase source);

    public abstract class SerialConnectionBase : IDisposable{
        private readonly SerialPort _serialPort = new SerialPort();

        protected SerialConnectionBase(string portName, int rate, Parity parity, int dataBits, StopBits stopBits,
                                       Handshake handshake, int readTimeout, int writeTimeout){
            InitPortProperties(portName, rate, parity, dataBits, stopBits, handshake, readTimeout, writeTimeout);
            LastReadLines = string.Empty;
        }

        public string LastReadLines { get; private set; }
        public bool AnswerReceived { get; private set; }

        public bool Connected{
            get { return _serialPort.IsOpen; }
        }

        public virtual bool Ready{
            get { return true; }
        }

        public abstract string Name { get; }

        public string Port{
            get { return _serialPort.PortName; }
            set { _serialPort.PortName = value; }
        }

        public int Baud{
            get { return _serialPort.BaudRate; }
            set { _serialPort.BaudRate = value; }
        }

        #region IDisposable Members

        public void Dispose(){
            Disconnect();
        }

        #endregion

        public event SerialConnectionEventHandler OnAnswerReceived;
        public event SerialConnectionEventHandler OnStateChanged;

        public void Close(){
            Dispose();
        }

        private void InitPortProperties(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits,
                                        Handshake handshake, int readTimeout, int writeTimeout){
            _serialPort.Encoding = Encoding.ASCII;
            _serialPort.DataReceived += _serialPort_DataReceived;
            _serialPort.PortName = portName;
            _serialPort.BaudRate = baudRate;
            _serialPort.Parity = parity;
            _serialPort.DataBits = dataBits;
            _serialPort.StopBits = stopBits;
            _serialPort.Handshake = handshake;
            _serialPort.ReadTimeout = readTimeout;
            _serialPort.WriteTimeout = writeTimeout;
        }

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e){
            if (!_serialPort.IsOpen)
                return;
            LastReadLines = _serialPort.ReadExisting();
            AnswerReceived = true;
            FireOnAnswerReceived();
        }

        protected virtual void FireOnAnswerReceived(){
            if (OnAnswerReceived != null)
                OnAnswerReceived(this);
        }

        public void WriteLine(string format, params object[] args){
            WriteLine(string.Format(format, args));
        }

        public void WriteLine(string message){
            Write(string.Format("{0}\n\r", message));
        }

        public void Write(string message){
            Write(message, new object[]{});
        }

        public void Write(string format, params object[] args){
            AnswerReceived = false;
            try{
                Connect();
                _serialPort.Write(string.Format(format, args) + "\n");
            }
            catch (Exception ex){
                Dispose();
                throw (ex);
            }
        }

        public void Connect(){
            if (!Connected && Ready)
                PerformConnect();
        }

        protected virtual void PerformConnect(){
            OpenSerialPort();
            FireStatusChanged();
        }

        protected void OpenSerialPort(){
            _serialPort.Open();
        }

        public void Disconnect(){
            if (!Connected)
                return;
            _serialPort.Close();
            FireStatusChanged();
        }

        protected void FireStatusChanged(){
            if (OnStateChanged != null)
                OnStateChanged(this);
        }
    }
}
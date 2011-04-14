using System;
using System.IO.Ports;
using System.Text;
using System.Text.RegularExpressions;

namespace SerialConnection{
    public class TelegesisETRX2Connection : SerialConnectionBase{
        private bool _isWaitingForDeviceUID;
        private const string INIT_NETWORK_COMMAND = "AT+SN";
        private const string OPEN_CHANNEL_COMMAND = "AT+OPCHAN";
        private const string CLOSE_CHANNEL_COMMAND = "+++";

        public TelegesisETRX2Connection(string portName, int rate, Parity parity, int dataBits, StopBits stopBits,
                                        Handshake handshake, int readTimeout, int writeTimeout)
            : base(portName, rate, parity, dataBits, stopBits, handshake, readTimeout, writeTimeout){
            LastReadLinesPool = new StringBuilder();
        }

        private StringBuilder LastReadLinesPool { get; set; }

        protected override void PerformConnect() {
            OpenSerialPort();
            //The module is expected to be turned on earlier - it's enough time to establish a pan
//            if (!WaitForAnswer("JPAN:"))
//                throw new SerialConnectionException("ZigBee pan has not established. Try to connect again.");
            Write(CLOSE_CHANNEL_COMMAND);
            ClearLastReadLinesPool();
            WriteLine(INIT_NETWORK_COMMAND);
            _isWaitingForDeviceUID = true;
        }

        public override string Name{
            get { return "ZigBee Telegesis ETRX2"; }
        }

        protected override void FireOnAnswerReceived(){
            LastReadLinesPool.Append(LastReadLines);
            if (_isWaitingForDeviceUID)
                InitDeviceUID();
            base.FireOnAnswerReceived();
        }

        private void InitDeviceUID(){
            string uid = GetDeviceUID();
            if (uid.Length != 16)
                return;
            WriteLine("{0}:{1}", OPEN_CHANNEL_COMMAND, uid);
            _isWaitingForDeviceUID = false;
            FireStatusChanged();
        }

        public override bool Ready{
            get { return !_isWaitingForDeviceUID; }
        }

        private string GetDeviceUID(){
            return GetReadTextBy("FFD:(?<UID>.{16})");
        }
        protected bool LastReadLinesListContains(string text) {
            string messages = LastReadLinesPool.ToString().ToUpper();
            return messages.Contains(text.ToUpper());
        }

        protected void ClearLastReadLinesPool() {
            LastReadLinesPool = new StringBuilder();
        }

        protected string GetReadTextBy(string pattern) {
            MatchCollection matchCollection = Regex.Matches(LastReadLinesPool.ToString().ToUpper(), pattern);
            if (matchCollection.Count == 0
                || matchCollection[0].Groups.Count == 0
                || matchCollection[0].Groups[1].Value.Length != 16)
                return string.Empty;
            return matchCollection[0].Groups[1].Value;
        }
    }
}
using ZigBee;
using ZigBeeLib;

namespace RVSLite{
    public class ZegBeeDriveService : IService{
        private readonly int _number;
        private readonly TelegesisETRX2Communicator _communicator;
        private int _value;

        public ZegBeeDriveService(string name, int number, TelegesisETRX2Communicator communicator){
            _number = number;
            _communicator = communicator;
            ServiceName = string.Format("{0}#{1}",name, _number);
        }

        public object Value{
            get { return _value; }
            set{
                var intValue = Settings.GetIntValueBy(value);
                bool changed = (_value == intValue);
                _value = intValue;
                var number = 2 * (_number - 1);
                int value1 = (_value >= 0 ? 1: 0);
                int value2 = (_value <= 0 ? 1: 0);
                const string nodeId = "000D6F0000178F83";
//                const string nodeId = "000D6F0000179029";
                _communicator.Write(string.Format("ATSREM0F{0}:{2}={1}", 7 - number, value1, nodeId));
                _communicator.Write(string.Format("ATSREM0F{0}:{2}={1}", 6 - number, value2, nodeId));
                if (changed && OnStateChanged != null)
                    OnStateChanged(_value);
            }
        }

        public string ServiceName { get; set; }

        public void SetValue(object value){
            Value = value;
        }

        public event ValueEventHandler OnStateChanged;
    }
}
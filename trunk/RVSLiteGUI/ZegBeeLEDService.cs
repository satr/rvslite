using ZigBee;

namespace RVSLite{
    public class ZegBeeLEDService : IService{
        private object _value;
        public ZegBeeLEDService(string name, TelegesisETRX2Communicator communicator) {
            ServiceName = name;
        }

        public object Value {
            get { throw new System.NotImplementedException(); }
            set {
                if (_value == value)
                    return;
                _value = value;
                if (OnStateChanged != null)
                    OnStateChanged(_value);
            }
        }

        public string ServiceName { get; set; }

        public void SetValue(object value) {
            Value = value;
        }

        public event ValueEventHandler OnStateChanged;
    }
}
using System;
using SerialConnection;

namespace RVSLite{
    public class SerialConnectionDriveService : IService{
        private readonly int _number;
        private int _value;

        public SerialConnectionDriveService(string name, int number){
            _number = number;
            ServiceName = string.Format("{0}#{1}", name, _number);
        }

        #region IService Members

        public object Value{
            get { return _value; }
            set{
                int intValue = Settings.GetIntValueBy(value);
                bool changed = (_value == intValue);
                _value = intValue;
//                _connectionServicesController.WriteLine(string.Format("atdrv{0}:{1}", _value > 0 ? "f" : "b", Math.Abs(_value)));
                if (changed && OnStateChanged != null)
                    OnStateChanged(_value);
            }
        }

        public string ServiceName { get; set; }

        public void SetValue(object value){
            Value = value;
        }

        public event ValueEventHandler OnStateChanged;

        #endregion
    }
}
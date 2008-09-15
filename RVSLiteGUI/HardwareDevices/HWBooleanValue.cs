using RVSLite.Controls;

namespace RVSLite.HardwareDevices{
    public class HWBooleanValue : IBooleanValue{
        private readonly IBooleanControl _booleanControl;

        public HWBooleanValue(IBooleanControl booleanControl){
            _booleanControl = booleanControl;
            _booleanControl.OnStateChanged += TriggerControl_OnStateChanged;
        }

        #region IBooleanValue Members

        public string Name{
            get { return _booleanControl.HWName; }
            set { _booleanControl.HWName = value; }
        }

        public object Value{
            get { return _booleanControl.Value; }
            set { _booleanControl.Value = (bool)value; }
        }

        public event PostEventHandler OnStateChanged;
        
        public void SetValue(object value) {
            Value = value;
        }

        #endregion

        private void TriggerControl_OnStateChanged(object value){
            if (OnStateChanged != null)
                OnStateChanged(Value);
        }

        public override string ToString(){
            return Name;
        }
    }
}
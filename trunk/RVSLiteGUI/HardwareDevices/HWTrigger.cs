using RVSLite.Controls;

namespace RVSLite.HardwareDevices{
    public class HWTrigger : IBooleanValue{
        private readonly ITriggerControl _triggerControl;

        public HWTrigger(ITriggerControl triggerControl){
            _triggerControl = triggerControl;
            _triggerControl.OnStateChanged += TriggerControl_OnStateChanged;
        }

        #region IBooleanValue Members

        public string Name{
            get { return _triggerControl.HWName; }
            set { _triggerControl.HWName = value; }
        }

        public bool Value{
            get { return _triggerControl.Value; }
            set { _triggerControl.Value = value; }
        }

        public event BooleanEventHandler OnStateChanged;
        
        public void SetValue(bool value) {
            Value = value;
        }

        #endregion

        private void TriggerControl_OnStateChanged(bool value){
            if (OnStateChanged != null)
                OnStateChanged(Value);
        }

        public override string ToString(){
            return Name;
        }
    }
}
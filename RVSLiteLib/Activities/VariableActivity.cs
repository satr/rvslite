namespace RVSLite{
    public class VariableActivity : BaseActivity{
        public event VariableActivityEventHandler OnChanged;
        private string _name;
        private static int _instanceCounter;
        public VariableActivity(): this(Lang.Res.Variable){
        }

        public VariableActivity(string name){
            _name = name;
            InstanceName = string.Format("{0}_{1}", Lang.Res.Variable, _instanceCounter++);
        }

        public string InstanceName { get; set; }

        public override string ToString(object value){
            return string.Format("{0} {1}", Name, InstanceName);
        }

        public override string Name{
            get { return _name; }
            set { _name = value; }
        }

        public override void Post(object value){
            if(value != null)
                Value = value;
            base.Post(Value);
        }

        private object _value;
        public object Value{
            set{
                if (_value == value)
                    return;
                _value = value;
                if (OnChanged != null)
                    OnChanged(this);
            }
            get { return _value; }
        }

        public override bool IsVariable {
            get { return true; }
        }

        public virtual bool RequireInitValue {
            get { return false; }
        }

        public override string ToString(){
            return ToString("");
        }
    }
}
namespace RVSLite{
    public class Variable : BaseActivity{
        private string _name;
        private static int _instanceCounter;
        public Variable(): this(Lang.Res.Variable){
        }

        public Variable(string name){
            _name = name;
            InstanceName = _instanceCounter++.ToString();
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
            Value = value;
            base.Post(Value);
        }

        public virtual object Value { set; get; }

        public override bool IsValueHolder {
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
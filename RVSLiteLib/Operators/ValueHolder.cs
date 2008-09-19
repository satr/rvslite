namespace RVSLite{
    public class ValueHolder : BaseOperator{
        private string _name;
        private static int _instanceCounter;
        public ValueHolder(): this(Lang.Res.Value){
        }

        public ValueHolder(string name){
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
    }
}
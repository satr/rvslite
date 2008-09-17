namespace RVSLite{
    public class ValueHolder : OperatorBase, IValueHolder{
        public static readonly string OperatorName = Lang.Res.Value;
        private string _name;
        private static int _instanceCounter;
        public ValueHolder() {
            _name = GetNextDefaultName();
        }

        public ValueHolder(object value)
            : this(GetNextDefaultName(), value) {
        }

        private static string GetNextDefaultName(){
            return string.Format("{0}_{1}", OperatorName, _instanceCounter++);
        }

        public ValueHolder(string name, object value){
            _name = name;
            Value = value;
        }

        public override string Name{
            get { return _name; }
            set { _name = value; }
        }

        public event ValueEventHandler OnStateChanged;

        public void SetValue(object value){
            Value = value;
        }

        public override void Post(object value){
            bool valueChanged = Value != value;
            Value = value;
            if (valueChanged && OnStateChanged != null)
                OnStateChanged(value);
            base.Post(Value);
        }

        #region IValueHolder Members

        public virtual object Value { set; get; }

        #endregion

        public override string ToString(){
            return string.Format("{0} {1}", Name, Value == null ? Lang.Res.Empty : Value.ToString());
        }
    }
}
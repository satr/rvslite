namespace RVSLite{
    public class ValueHolder : OperatorBase, IValueHolder{
        private readonly string _name;
        private static int _instanceCounter;
        public ValueHolder() {
            _name = GetNextDEfaultName();
        }

        public ValueHolder(object value)
            : this(GetNextDEfaultName(), value) {
        }

        private static string GetNextDEfaultName(){
            return string.Format("{0}_{1}", Lang.Res.Value, _instanceCounter++);
        }

        public ValueHolder(string name, object value){
            _name = name;
            Value = value;
        }

        public override string Name{
            get { return _name; }
        }

        #region IValueHolder Members

        public virtual object Value { set; get; }

        #endregion

        public override string ToString(){
            return string.Format("{0} {1}", Name, Value == null ? Lang.Res.Empty : Value.ToString());
        }
    }
}
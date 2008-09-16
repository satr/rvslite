namespace RVSLite {
    public abstract class BooleanValueBase : ValueHolder, IBooleanValue {
        protected string _valueIsFalseText;
        protected string _valueIsTrueText;
        protected string _name;

        protected BooleanValueBase(string name, string valueIsTrueText, string valueIsFalseText) {
            _name = name;
            _valueIsTrueText = valueIsTrueText;
            _valueIsFalseText = valueIsFalseText;
            Value = false;
        }

        public override string ToString() {
            return string.Format("{0} {1}", Name, GetBoolValue() ? _valueIsTrueText : _valueIsFalseText); 
        }

        public override object Value {
            get { return base.Value; }
            set{
                if (base.Value != null && (bool)base.Value == (bool)value)
                    return;
                base.Value = value;
                if (OnStateChanged != null)
                    OnStateChanged(value);
            }
        }

        string IBooleanValue.Name { get; set; }

        private bool GetBoolValue() {
            if(Value is bool)
                return ((bool) Value);
            if (Value is string)
                return !string.IsNullOrEmpty(Value as string);
            decimal dec;
            return decimal.TryParse(Value == null ? "0" : Value.ToString(), out dec) && dec != 0;
        }

        public override string Name {
            get { return _name; }
        }

        public event PostEventHandler OnStateChanged;
        public void SetValue(object value){
            throw new System.NotImplementedException();
        }
    }
}
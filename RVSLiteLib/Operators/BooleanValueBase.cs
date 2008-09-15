namespace RVSLite {
    public abstract class BooleanValueBase : ValueHolder {
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

        private bool GetBoolValue(){
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
    }
}
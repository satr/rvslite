namespace RVSLite {
    public abstract class TriggerValueBase : ValueHolder {
        protected string _valueIsFalseText;
        protected string _valueIsTrueText;
        protected string _name;

        protected TriggerValueBase(string name, string valueIsTrueText, string valueIsFalseText) {
            _name = name;
            _valueIsTrueText = valueIsTrueText;
            _valueIsFalseText = valueIsFalseText;
            Value = false;
        }

        public override string ToString() {
            return string.Format("{0} {1}", Name, ((bool) Value) ? _valueIsTrueText : _valueIsFalseText); 
        }

        public override string Name {
            get { return _name; }
        }

        public override void Post() {
            Value = !(bool) Value;
            base.Post();
        }
    }
}
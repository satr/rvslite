using System;

namespace RVSLite {
    public class LED : TriggerValueBase {
        new public static readonly string OperatorName = Lang.Res.LED;
        private static int _instanceCounter;
        private IValueHolder _valueHolder;

        public LED()
            : this(string.Format("{0}#{1}", OperatorName, _instanceCounter++)) {}

        public LED(string name) : base(name, Lang.Res.On, Lang.Res.Off) {
        }

        public override object Value {
            get { return _valueHolder.Value; }
            set { }
        }

        public override string ToString(){
            return string.Format("{0}: {1}", Name, ((bool)Value) ? _valueIsTrueText : _valueIsFalseText);
        }

        public override void ListenTo(OperatorBase sourceOperator) {
            _valueHolder = (IValueHolder)sourceOperator;
            base.ListenTo(sourceOperator);
        }
    }
}
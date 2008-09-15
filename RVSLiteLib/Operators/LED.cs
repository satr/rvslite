using System;

namespace RVSLite {
    public class LED : BooleanValueBase {
        new public static readonly string OperatorName = Lang.Res.LED;
        private static int _instanceCounter;

        public LED()
            : this(string.Format("{0}#{1}", OperatorName, _instanceCounter++)) {}

        public LED(string name) : base(name, Lang.Res.On, Lang.Res.Off) {
        }

        public override string ToString(){
            return string.Format("{0}: {1}", Name, ((bool)Value) ? _valueIsTrueText : _valueIsFalseText);
        }
    }
}
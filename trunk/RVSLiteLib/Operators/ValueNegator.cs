namespace RVSLite {
    public class ValueNegator : ValueHolderContainerBase, IValueHolder {
        public static readonly string OperatorName = Lang.Res.Negate_value;
        public object Value {
            get { return !((bool) _valueHolder.Value); }
            set { _valueHolder.Value = !((bool)value); }
        }

        public override string Name{
            get { return OperatorName; }
        }
    }
}
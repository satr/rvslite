namespace RVSLite {
    public class ValueNegator : ValueHolderContainerBase, IValueHolder {
        public object Value {
            get { return !((bool) _valueHolder.Value); }
            set { _valueHolder.Value = !((bool)value); }
        }

        public override string Name{
            get { return Lang.Res.Negate_value; }
        }
    }
}
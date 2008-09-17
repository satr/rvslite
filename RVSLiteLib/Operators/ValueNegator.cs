namespace RVSLite{
    public class ValueNegator : ValueHolderContainerBase, IValueHolder{
        public static readonly string OperatorName = Lang.Res.Negate_value;

        public ValueNegator(){
        }

        public ValueNegator(IValueHolder valueHolder) : base(valueHolder){
        }

        #region IValueHolder Members

        public object Value{
            get { return !((bool) _valueHolder.Value); }
            set{
                var newValue = (bool) value;
                var valueChanged = (bool)_valueHolder.Value != newValue;
                _valueHolder.Value = !newValue;
                if (valueChanged && OnStateChanged != null)
                    OnStateChanged(Value);
            }
        }

        public override string Name{
            get { return OperatorName; }
            set { }
        }

        public event ValueEventHandler OnStateChanged;
        
        public void SetValue(object value){
            Value = value;
        }

        #endregion
    }
}
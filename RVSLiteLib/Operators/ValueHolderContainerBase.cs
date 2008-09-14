namespace RVSLite{
    public abstract class ValueHolderContainerBase : OperatorBase{
        protected IValueHolder _valueHolder;

        protected ValueHolderContainerBase() : this(null){
        }

        protected ValueHolderContainerBase(IValueHolder valueHolder){
            _valueHolder = valueHolder;
        }

        public override void ListenTo(OperatorBase sourceOperator) {
            if(_valueHolder == null)
                _valueHolder = (IValueHolder)sourceOperator;
            base.ListenTo(sourceOperator);
        }

        public override string ToString() {
            return string.Format("{0}: {1}", Name, _valueHolder); 
        }
    }
}
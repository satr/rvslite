namespace RVSLite{
    public class ValueSetter : ValueHolderContainerBase{
        private readonly IValueHolder _sourceValueHolder;

        public ValueSetter(IValueHolder targetValueHolder, IValueHolder sourceValueHolder)
            : base(targetValueHolder){
            _sourceValueHolder = sourceValueHolder;
        }

        public override string Name{
            get { return Lang.Res.SetValue; }
        }

        public override void Post(){
            _valueHolder.Value = _sourceValueHolder.Value;
            base.Post();
        }

        public override string ToString(){
            return string.Format("{0}: {1} = {2}", Name, _valueHolder.Name, _sourceValueHolder.Value);
        }
    }
}
namespace RVSLite{
    public class ValueSetter : ValueHolderContainerBase{
        private readonly IValueHolder _sourceValueHolder;
        public static readonly string OperatorName = Lang.Res.SetValue;

        public ValueSetter(IValueHolder targetValueHolder, IValueHolder sourceValueHolder)
            : this(targetValueHolder){
            _sourceValueHolder = sourceValueHolder;
        }

        public ValueSetter(IValueHolder targetValueHolder) : base(targetValueHolder) { }

        public override string Name{
            get { return OperatorName; }
        }

        public override void Post(object value){
            _valueHolder.Value = GetValueBy(_sourceValueHolder, value);
            base.Post(_valueHolder.Value);
        }

        private static object GetValueBy(IValueHolder sourceValueHolder, object alterValue){
            return sourceValueHolder != null? sourceValueHolder.Value: alterValue;
        }

        public override string ToString(){
            return string.Format("{0}: {1} = {2}", Name, _valueHolder.Name, GetValueBy(_sourceValueHolder, Lang.Res.Entry_value));
        }
    }
}
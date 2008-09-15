namespace RVSLite{
    public class Negator : OperatorBase{
        public static readonly string OperatorName = Lang.Res.Negate_entry_value;

        public override string Name{
            get { return OperatorName; }
        }

        public override void Post(object value){
            if (value is bool)
                value = !((bool) value);
            base.Post(value);
        }
    }
}
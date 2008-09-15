namespace RVSLite{
    public class NullOperator : OperatorBase{
        public static readonly string OperatorName = Lang.Res.Undefined;
        public override string Name{
            get { return OperatorName; }
        }

        public override void Post(object value){
            DisplayThis();
        }

        public override string ToString(){
            return Lang.Res.Undefined_operator_is_called;
        }
    }
}
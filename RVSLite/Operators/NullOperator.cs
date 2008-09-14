namespace RVSLite{
    public class NullOperator : OperatorBase{
        public override string Name{
            get { return Lang.Res.Undefined; }
        }

        public override void Post(){
            DisplayThis();
        }

        public override string ToString(){
            return Lang.Res.Undefined_operator_is_called;
        }
    }
}
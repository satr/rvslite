namespace RVSLite{
    public class IfClause : OperatorWithOperation{
        private readonly BaseOperator _negativeResult = new BaseOperator();
        private readonly BaseOperator _positiveResult = new BaseOperator();

        public IfClause(string name) : base(name){
        }

        public BaseOperator Positive{
            get { return _positiveResult; }
        }

        public BaseOperator Negative{
            get { return _negativeResult; }
        }

        public override void Post(object value){
            DisplayThis(value);
            if ((bool) _operationCommand.Perform(value, _valueHolder))
                Positive.Post(value);
            else
                Negative.Post(value);
        }
    }
}
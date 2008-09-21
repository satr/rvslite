namespace RVSLite{
    public class IfClause : ActivityWithOperation{
        private readonly BaseActivity _negativeResult = new BaseActivity();
        private readonly BaseActivity _positiveResult = new BaseActivity();

        public IfClause(string name) : base(name){
        }

        public BaseActivity Positive{
            get { return _positiveResult; }
        }

        public BaseActivity Negative{
            get { return _negativeResult; }
        }

        public override void Post(object value){
            DisplayThis(value);
            if ((bool) _operationCommand.Perform(value, _variable))
                Positive.Post(value);
            else
                Negative.Post(value);
        }
    }
}
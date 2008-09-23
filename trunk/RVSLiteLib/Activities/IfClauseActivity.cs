namespace RVSLite{
    public class IfClauseActivity : ActivityWithOperation{
        private readonly BaseActivity _negativeResult = new BaseActivity();
        private readonly BaseActivity _positiveResult = new BaseActivity();

        public IfClauseActivity(string name) : base(name){
            _operationCommand = new EqualConditionCommand();
        }

        public BaseActivity Positive{
            get { return _positiveResult; }
        }

        public BaseActivity Negative{
            get { return _negativeResult; }
        }

        public override void Post(object value){
            if ((bool) _operationCommand.Perform(value, _variableOrData))
                Positive.Post(value);
            else
                Negative.Post(value);
        }
    }
}
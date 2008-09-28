namespace RVSLite{
    public class VariableActivityHolder : BaseActivity{
        public VariableActivityHolder(){
            InnerVariableActivity = new BaseActivity();
        }

        public BaseActivity InnerVariableActivity { get; set; }

        public override void Post(object value){
            var variableActivity = ((VariableActivity)InnerVariableActivity);
            if (value != null)
                variableActivity.Value = value;
            base.Post(variableActivity.Value);
        }
    }
}
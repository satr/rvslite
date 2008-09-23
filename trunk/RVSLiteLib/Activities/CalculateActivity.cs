namespace RVSLite{
    public class CalculateActivity : ActivityWithOperation{
        public CalculateActivity(string name) : base(name){
            _operationCommand = new SumCalculationCommand();
        }

        public override void Post(object value){
            base.Post(_operationCommand.Perform(value, _variableOrData.Value));
        }
    }
}
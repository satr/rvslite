namespace RVSLite{
    public class Calculate : ActivityWithOperation{
        public Calculate(string name) : base(name){
        }

        public override void Post(object value){
            base.Post(_operationCommand.Perform(value, _variable.Value));
        }
    }
}
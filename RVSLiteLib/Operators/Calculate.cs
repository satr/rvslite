namespace RVSLite{
    public class Calculate : OperatorWithOperation{
        public Calculate(string name) : base(name){
        }

        public override void Post(object value){
            base.Post(_operationCommand.Perform(value, _valueHolder.Value));
        }
    }
}
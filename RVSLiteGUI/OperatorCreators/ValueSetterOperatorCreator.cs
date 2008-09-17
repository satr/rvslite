namespace RVSLite{
    public class ValueSetterOperatorCreator : OperatorCreatorBase{
        public ValueSetterOperatorCreator(IServiceProvider services) : base(services) {}

        public override string Name {
            get { return ValueSetter.OperatorName; }
        }

        protected override OperatorBase Create(){
            return new ValueSetter(null, null);
        }
    }
}
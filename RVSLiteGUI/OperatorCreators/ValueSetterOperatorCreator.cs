namespace RVSLite{
    public class ValueSetterOperatorCreator : ElementCreatorBase{
        public ValueSetterOperatorCreator(IServiceProvider services) : base(services) {}

//        public override OperatorBase Create(){
//            return new ValueSetter(new ValueHolder(), new ValueHolder());
//        }

        public override string Name {
            get { return ValueSetter.OperatorName; }
        }
    }
}
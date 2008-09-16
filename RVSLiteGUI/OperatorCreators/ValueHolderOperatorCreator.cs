namespace RVSLite{
    public class ValueHolderOperatorCreator : ElementCreatorBase{
        public ValueHolderOperatorCreator(IServiceProvider services) : base(services) {}

//        public override OperatorBase Create(){
//            return new ValueHolder();
//        }

        public override string Name {
            get { return ValueHolder.OperatorName; }
        }
    }
}
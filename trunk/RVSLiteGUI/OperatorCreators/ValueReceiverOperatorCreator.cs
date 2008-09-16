namespace RVSLite{
    public class ValueReceiverOperatorCreator : ElementCreatorBase{
        public ValueReceiverOperatorCreator(IServiceProvider services) : base(services) {}

//        public override OperatorBase Create(){
//            return new ValueReceiver();
//        }

        public override string Name {
            get { return ValueReceiver.OperatorName; }
        }
    }
}
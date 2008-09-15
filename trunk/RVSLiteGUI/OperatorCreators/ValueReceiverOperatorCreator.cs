namespace RVSLite{
    public class ValueReceiverOperatorCreator : OperatorCreatorBase{
        public ValueReceiverOperatorCreator(IHardwareInterface hardware) : base(hardware) {}

        public override OperatorBase Create(){
            return new ValueReceiver();
        }

        public override string Name {
            get { return ValueReceiver.OperatorName; }
        }
    }
}
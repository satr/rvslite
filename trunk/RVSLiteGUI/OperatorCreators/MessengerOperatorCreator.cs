namespace RVSLite{
    public class MessengerOperatorCreator : OperatorCreatorBase{
        public MessengerOperatorCreator(IHardwareInterface hardware) : base(hardware) {}

        public override OperatorBase Create(){
            return new Messenger();
        }

        public override string Name{
            get { return Messenger.OperatorName; }
        }
    }
}
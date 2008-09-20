namespace RVSLite{
    public class MessengerOperatorCreator : ElementCreatorBase{
        public MessengerOperatorCreator(IServiceProvider services) : base(services) {}

        public override string Name{
            get { return Messenger.OperatorName; }
        }

        public override BaseOperator Create(){
            return new Messenger();
        }
    }
}
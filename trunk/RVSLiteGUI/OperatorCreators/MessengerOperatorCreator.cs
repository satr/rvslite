namespace RVSLite{
    public class MessengerOperatorCreator : ElementCreatorBase{
        public MessengerOperatorCreator(IServiceProvider services) : base(services) {}

//        public override OperatorBase Create(){
//            return new Messenger();
//        }

        public override string Name{
            get { return Messenger.OperatorName; }
        }
    }
}
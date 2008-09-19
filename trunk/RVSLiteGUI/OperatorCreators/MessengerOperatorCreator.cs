namespace RVSLite{
    public class MessengerOperatorCreator : ElementCreatorBase{
        public MessengerOperatorCreator(IServiceProvider services) : base(services) {}

//        public override BaseOperator Create(){
//            return new Messenger();
//        }

        public override string Name{
            get { return Messenger.OperatorName; }
        }
    }
}
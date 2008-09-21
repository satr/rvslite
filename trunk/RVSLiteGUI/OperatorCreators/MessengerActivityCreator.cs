namespace RVSLite{
    public class MessengerActivityCreator : ActivityCreatorBase{
        public MessengerActivityCreator(IServiceProvider services) : base(services) {}

        public override string Name{
            get { return Lang.Res.Messenger; }
        }

        public override BaseActivity Create(){
            return new Messenger();
        }
    }
}
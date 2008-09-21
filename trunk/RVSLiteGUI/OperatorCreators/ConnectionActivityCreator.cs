namespace RVSLite{
    public class ConnectionActivityCreator : SingleInstanceActivityCreatorBase {
        public ConnectionActivityCreator(IServiceProvider serviceProvider) : base(serviceProvider) {}

        public override BaseActivity Create() {
            return new BaseActivity(Name);
        }

        public override string Name {
            get { return Lang.Res.Connection; }
        }

        public override bool IsAnonymous{
            get { return true; }
        }
    }
}
namespace RVSLite{
    public class ConnectionOperatorCreator : SingleOperatorCreatorBase {
        public ConnectionOperatorCreator(IServiceProvider serviceProvider) : base(serviceProvider) {}

        public override BaseOperator Create() {
            return new BaseOperator(Name);
        }

        public override string Name {
            get { return Lang.Res.Connection; }
        }

        public override bool IsAnonymous{
            get { return true; }
        }
    }
}
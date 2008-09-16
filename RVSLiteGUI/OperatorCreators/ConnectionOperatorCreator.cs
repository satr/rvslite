namespace RVSLite{
    public class ConnectionOperatorCreator : OperatorCreatorBase {
        public ConnectionOperatorCreator(IServiceProvider serviceProvider) : base(serviceProvider) {}

        protected override OperatorBase Create() {
            return new Connection();
        }

        public override string Name {
            get { return Connection.OperatorName; }
        }
    }
}
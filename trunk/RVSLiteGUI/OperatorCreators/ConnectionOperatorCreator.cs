namespace RVSLite{
    public class ConnectionOperatorCreator : SingleOperatorCreatorBase {
        public ConnectionOperatorCreator(IServiceProvider serviceProvider) : base(serviceProvider) {}

        protected override BaseOperator Create() {
            return new BaseOperator(Name);
        }

        public override string Name {
            get { return Connection.OperatorName; }
        }
    }
}
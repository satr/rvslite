namespace RVSLite{
    public class ConnectionOperatorCreator : OperatorCreatorBase {
        public ConnectionOperatorCreator(IHardwareInterface hardware) : base(hardware) {}

        public override OperatorBase Create() {
            return new Connection();
        }

        public override string Name {
            get { return Connection.OperatorName; }
        }
    }
}
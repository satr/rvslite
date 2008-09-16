using System.Collections;

namespace RVSLite{
    public class ConnectionOperatorCreator : OperatorCreatorBase {
        public ConnectionOperatorCreator(IServiceProvider serviceProvider) : base(serviceProvider) {}

        protected override OperatorBase Create() {
            return new Connection();
        }

        public override string Name {
            get { return Connection.OperatorName; }
        }

        public override IList Instances{
            get{
                _instances.Clear();
                _instances.Add(Create());
                return _instances;
            }
        }
    }
}
using System.Collections.Generic;

namespace RVSLite{
    public abstract class OperatorWithOperationCreatorBase : SingleOperatorCreatorBase{
        protected OperatorWithOperationCreatorBase(IServiceProvider services) : base(services) {
        }

        public override bool IsOperatorWithOperation{
            get { return true; }
        }

        public abstract IEnumerable<OperationsCommandBase> OperationCommands { get; }
    }
}
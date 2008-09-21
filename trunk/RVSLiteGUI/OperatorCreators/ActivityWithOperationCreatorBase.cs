using System.Collections.Generic;

namespace RVSLite{
    public abstract class ActivityWithOperationCreatorBase : SingleInstanceActivityCreatorBase{
        protected ActivityWithOperationCreatorBase(IServiceProvider services) : base(services) {
        }

        public override bool IsOperatorWithOperation{
            get { return true; }
        }

        public abstract IEnumerable<OperationsCommandBase> OperationCommands { get; }
    }
}
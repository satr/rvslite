using System.Collections.Generic;

namespace RVSLite{
    public abstract class ActivityWithOperationFactoryBase : SingleInstanceActivityFactoryBase{
        protected ActivityWithOperationFactoryBase(IServiceProvider services) : base(services) {
        }

        public abstract IEnumerable<OperationsCommandBase> OperationCommands { get; }
    }
}
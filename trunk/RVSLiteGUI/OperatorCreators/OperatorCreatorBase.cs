using System.Collections.Generic;

namespace RVSLite{
    public abstract class OperatorCreatorBase{
        protected readonly IHardwareInterface _hardware;

        protected OperatorCreatorBase(IHardwareInterface hardware) {
            _hardware = hardware;
        }

        public abstract OperatorBase Create();

        public abstract string Name { get; }
    }
}
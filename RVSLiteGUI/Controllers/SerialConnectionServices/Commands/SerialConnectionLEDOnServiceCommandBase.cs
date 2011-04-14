using System.Collections.Generic;

namespace RVSLite{
    internal abstract class SerialConnectionLEDOnServiceCommandBase : SerialConnectionServiceCommandBase{
        protected SerialConnectionLEDOnServiceCommandBase(string commandData, IDictionary<byte, IService> services)
            : base(commandData, services, 0) {
        }

        protected override string CustomCommandDataPattern{
            get { return "[A-Fa-f]{2}"; }
        }
    }
}
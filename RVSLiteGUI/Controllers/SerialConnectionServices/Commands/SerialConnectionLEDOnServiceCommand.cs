using System;
using System.Collections.Generic;

namespace RVSLite{
    internal class SerialConnectionLEDOnServiceCommand: SerialConnectionLEDOnServiceCommandBase{
        public SerialConnectionLEDOnServiceCommand(string commandData, IDictionary<byte, IService> services)
            : base(commandData, services) {
        }

        public override void Perform(){
            Service.Value = true;
        }
    }
}
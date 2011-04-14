using System.Collections.Generic;

namespace RVSLite{
    internal class SerialConnectionLEDOffServiceCommand : SerialConnectionLEDOnServiceCommandBase{
        public SerialConnectionLEDOffServiceCommand(string commandData, IDictionary<byte, IService> services) : base(commandData, services){
        }

        public override void Perform(){
            Service.Value = false;
        }
    }
}
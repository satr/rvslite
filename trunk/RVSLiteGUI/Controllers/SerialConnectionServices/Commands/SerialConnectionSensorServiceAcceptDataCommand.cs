using System.Collections.Generic;

namespace RVSLite{
    internal class SerialConnectionSensorServiceAcceptDataCommand : SerialConnectionServiceCommandBase{
        private const int ADDRESS_INDEX = 0;
        private const int DATA_INDEX = 2;
        public SerialConnectionSensorServiceAcceptDataCommand(string commandData, IDictionary<byte, IService> services) 
            : base(commandData, services, ADDRESS_INDEX){
        }

        protected override string CustomCommandDataPattern{
            get { return @"[\dA-Fa-f]{4}"; }
        }

        public override void Perform(){
            Service.Value = GetByteAt(DATA_INDEX);
        }
    }
}
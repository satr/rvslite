using SerialConnection;

namespace RVSLite{
    internal abstract class ServiceStateChangedCommand {
        protected ServiceStateChangedCommand(byte address, SerialConnectionServicesController serialConnectionServicesController) {
            Address = address;
            SerialConnectionServicesController = serialConnectionServicesController;
        }

        private SerialConnectionServicesController SerialConnectionServicesController { get; set; }

        protected SerialConnectionBase Connection {
            get { return SerialConnectionServicesController.TerminalController.Connection; }
        }

        public byte Address { get; private set; }

        public abstract void Service_OnStateChanged(object value);
    }
}
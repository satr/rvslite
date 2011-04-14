namespace RVSLite{
    internal class LEDServiceStateChangedCommand : ServiceStateChangedCommand {
        public LEDServiceStateChangedCommand(byte address, SerialConnectionServicesController serialConnectionServicesController)
            : base(address, serialConnectionServicesController) {
        }

        public override void Service_OnStateChanged(object value) {
            Connection.Write("Q03{0:X2}{1:X2}", Address, (bool)value ? "01" : "00");
        }
    }
}
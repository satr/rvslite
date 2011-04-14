namespace RVSLite{
    public class DeviceServicesController{
        private readonly TerminalController _terminalController;

        public DeviceServicesController(TerminalController terminalController){
            _terminalController = terminalController;
        }
    }
}
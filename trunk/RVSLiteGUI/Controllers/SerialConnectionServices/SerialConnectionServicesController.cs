using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using SerialConnection;

namespace RVSLite{
    internal class SerialConnectionServicesController{
        private readonly TerminalController _terminalController;
        private StringBuilder _lastReadLines = new StringBuilder();

        public SerialConnectionServicesController(TerminalController terminalController){
            _terminalController = terminalController;
            DriveServices = new Dictionary<byte, IService>();
            LEDServices = new Dictionary<byte, IService>();
            BumperServices = new Dictionary<byte, IService>();
            Bind();
        }

        private void terminalController_OnAnswerReceived(SerialConnectionBase source){
            AppendText(source.LastReadLines);
        }

        private void AppendText(string text){
            _lastReadLines.Append(text);
            foreach (var command in GetCommands())
                command.Perform();
        }

        private List<SerialConnectionServiceCommandBase> GetCommands(){
            var matchCollection = Regex.Matches(_lastReadLines.ToString(), @"Q[\dA-Fa-f]+(\*|$)");
            _lastReadLines = new StringBuilder();
            var commands = new List<SerialConnectionServiceCommandBase>();
            foreach (Match match in matchCollection) {
                var line = Regex.Replace(match.Value, @"[\s\r\n]", "");
                if (line.Length == 0)
                    continue;
                if (line.EndsWith("*")) {
                    if (Regex.IsMatch(line, @"Q[\dA-Fa-f]{2,}\*"))
                        commands.Add(SerialConnectionServiceCommandFactory.CreateBy(line, this));
                }
                else
                    _lastReadLines.Append(line);
            }
            return commands;
        }

        private void Bind(){
            _terminalController.OnAnswerReceived += terminalController_OnAnswerReceived;
            _terminalController.OnClear += terminalController_OnClear;
        }

        void terminalController_OnClear(SerialConnectionBase source) {
            _lastReadLines = new StringBuilder();
        }

        public TerminalController TerminalController{
            get { return _terminalController; }
        }

        public IService Add(SerialConnectionDriveService service, byte address){
            DriveServices.Add(address, service);
            return service;
        }

        public IService Add(SerialConnectionBumperService service, byte address){
            BumperServices.Add(address, service);
            return service;
        }

        public IService Add(SerialConnectionLEDService service, byte address){
            LEDServices.Add(address, service);
            service.OnStateChanged += CreateLEDServiceStateChangedCommandFor(address);
            return service;
        }

        private ValueEventHandler CreateLEDServiceStateChangedCommandFor(byte address){
            return new LEDServiceStateChangedCommand(address, this).Service_OnStateChanged;
        }

        public Dictionary<byte, IService> DriveServices { get; set; }
        public Dictionary<byte, IService> LEDServices { get; set; }
        public Dictionary<byte, IService> BumperServices { get; set; }
    }
}
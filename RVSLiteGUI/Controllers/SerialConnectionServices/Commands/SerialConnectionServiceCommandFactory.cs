using System;
using System.Text.RegularExpressions;

namespace RVSLite{
    internal class SerialConnectionServiceCommandFactory{
        public static SerialConnectionServiceCommandBase CreateBy(string commandText, SerialConnectionServicesController serialConnectionServicesController){
            string command = Regex.Replace(commandText, @"[\*Q]", "");
            var commandId = command.Substring(0, 2);
            var commandData = command.Substring(2);
            try{
                return CreateCommandBy(commandId, commandData, serialConnectionServicesController);
            }
            catch (Exception ex){
                return new SerialConnectionWrongServiceCommand(command, ex);
            }
        }

        private static SerialConnectionServiceCommandBase CreateCommandBy(string commandId, string commandData, SerialConnectionServicesController serialConnectionServicesController){
            switch (commandId){
                case "04":
                    return new SerialConnectionSensorServiceAcceptDataCommand(commandData, serialConnectionServicesController.BumperServices);
            }
            throw new Exception(string.Format("Command has not been defined for ID={0}", commandId));
        }
    }
}
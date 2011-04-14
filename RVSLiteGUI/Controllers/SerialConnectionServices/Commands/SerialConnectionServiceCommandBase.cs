using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RVSLite{
    internal abstract class SerialConnectionServiceCommandBase{
        private string CommandData { get; set; }

        protected SerialConnectionServiceCommandBase(string commandData){
            CommandData = commandData;
        }

        protected SerialConnectionServiceCommandBase(string commandData, IDictionary<byte, IService> services, int serviceAddressIndex)
            :this(commandData){
            if (!Regex.IsMatch(commandData, CommandDataPattern))
                throw new Exception(string.Format("Wrong command data \"{0}\". Expected \"{1}\"", commandData, CommandDataPattern));
            Service = GetServiceBy(services, GetByteAt(serviceAddressIndex));
        }

        protected abstract string CustomCommandDataPattern { get; }

        private string CommandDataPattern{
            get { return CustomCommandDataPattern; }
        }

        protected IService Service { get; set; }

        protected byte GetByteAt(int index){
            return byte.Parse(CommandData.Substring(index, 2));
        }

        private static IService GetServiceBy(IDictionary<byte, IService> services, byte address){
            if(!services.ContainsKey(address))
                throw new Exception(string.Format("Service not exists with the address {0}", address));
            return services[address];
        }

        public abstract void Perform();
    }
}
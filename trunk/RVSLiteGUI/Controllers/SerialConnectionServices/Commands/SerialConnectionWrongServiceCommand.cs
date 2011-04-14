using System;

namespace RVSLite{
    internal class SerialConnectionWrongServiceCommand : SerialConnectionServiceCommandBase{
        private readonly Exception _ex;

        public SerialConnectionWrongServiceCommand(string commandData, Exception ex) : base(commandData){
            _ex = ex;
        }

        protected override string CustomCommandDataPattern{
            get { return ".*"; }
        }

        public override void Perform(){
            //do nothing
        }
    }
}
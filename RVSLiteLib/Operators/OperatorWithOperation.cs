using System.Collections.Generic;

namespace RVSLite{
    public abstract class OperatorWithOperation : BaseOperator{
        protected OperationsCommandBase _operationCommand;
        protected ValueHolder _valueHolder;

        protected OperatorWithOperation(string name) : base(name){
        }

        public BaseOperator InitBy(OperationsCommandBase operationCommand, ValueHolder valueHolder) {
            _operationCommand = operationCommand;
            _valueHolder = valueHolder;
            return this;
        }

        public override bool IsOperatorWithOperation{
            get { return true; }
        }

        public override string ToString(object value){
            return string.Format("{0}: [{1}] {2} [{3}]",
                                 Name,
                                 value,
                                 _operationCommand,
                                 _valueHolder);
        }

        public OperationsCommandBase OperationCommand{
            get { return _operationCommand; }
        }

        public ValueHolder ValueHolder{
            get { return _valueHolder; }
        }
    }
}
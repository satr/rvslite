using System.Collections.Generic;

namespace RVSLite{
    public abstract class ActivityWithOperation : BaseActivity{
        protected OperationsCommandBase _operationCommand;
        protected Variable _variable;

        protected ActivityWithOperation(string name) : base(name){
        }

        public BaseActivity InitBy(OperationsCommandBase operationCommand, Variable variable) {
            _operationCommand = operationCommand;
            _variable = variable;
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
                                 _variable);
        }

        public OperationsCommandBase OperationCommand{
            get { return _operationCommand; }
        }

        public Variable Variable{
            get { return _variable; }
        }
    }
}
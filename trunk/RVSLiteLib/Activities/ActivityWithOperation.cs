using System.Collections.Generic;

namespace RVSLite{
    public abstract class ActivityWithOperation : BaseActivity{
        protected OperationsCommandBase _operationCommand = new UndefinedOperationsCommand();
        protected VariableActivity _variableOrData = new DataActivity();

        protected ActivityWithOperation(string name) : base(name){
        }

        public BaseActivity InitBy(OperationsCommandBase operationCommand, VariableActivity variable) {
            _operationCommand = operationCommand;
            _variableOrData = variable;
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
                                 _variableOrData);
        }

        public OperationsCommandBase OperationCommand{
            get { return _operationCommand; }
        }

        public VariableActivity VariableOrDataActivity{
            get { return _variableOrData; }
        }
    }
}
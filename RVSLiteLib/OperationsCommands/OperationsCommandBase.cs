using System;

namespace RVSLite{
    public abstract class OperationsCommandBase{
        public abstract object Perform(object value1, object value2);
    }

    class UndefinedOperationsCommand : OperationsCommandBase{
        public override object Perform(object value1, object value2){
            throw new Exception(Lang.Res.Undefined_operation);
        }

        public override string ToString(){
            return Lang.Res.Undefined;
        }
    }
}
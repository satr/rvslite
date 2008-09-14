using System;

namespace RVSLite{
    public abstract class ConditionCommandBase{
        public abstract bool GetConditionResult(IValueHolder valueHolder1, IValueHolder valueHolder2);

        protected static bool CheckValuesAreInvalid(IValueHolder valueHolder1, IValueHolder valueHolder2){
            if (valueHolder1.Value == null || valueHolder2.Value == null)
                return false;
            if (valueHolder1.Value.GetType() != valueHolder2.Value.GetType())
                return false;
            return true;
        }

        protected static int GetInnerConditionResult(IValueHolder valueHolder1, IValueHolder valueHolder2){
            if (!CheckValuesAreInvalid(valueHolder1, valueHolder2))
                return -1;
            if (valueHolder1.Value is int)
                return ((int) valueHolder1.Value).CompareTo((int) valueHolder2.Value);
            if (valueHolder1.Value is bool)
                return ((bool) valueHolder1.Value).CompareTo((bool) valueHolder2.Value);
            if (valueHolder1.Value is string)
                return ((string) valueHolder1.Value).CompareTo((string) valueHolder2.Value);
            throw new Exception(Lang.Res.Undefined_condition_operation);
        }
    }
}
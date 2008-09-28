using System;

namespace RVSLite{
    public abstract class ConditionCommandBase : OperationsCommandBase {
        protected static bool CheckValuesAreInvalid(object value1, object value2){
            if (value1 == null || value2 == null)
                return false;
            if (value1.GetType() != value2.GetType())
                return false;
            return true;
        }

        protected static int GetInnerConditionResult(object value1, object value2){
            if (!CheckValuesAreInvalid(value1, value2))
                return -1;
            if (value1 is int)
                return ((int) value1).CompareTo((int) value2);
            if (value1 is bool)
                return ((bool) value1).CompareTo((bool) value2);
            if (value1 is string)
                return ((string) value1).CompareTo((string) value2);
            throw new Exception(Lang.Res.Undefined_condition_operation);
        }
    }
}
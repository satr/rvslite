using System;

namespace RVSLite{
    public class VariableIsNotDefinedException : Exception{
        public VariableIsNotDefinedException(VariableActivity activity)
            :base(string.Format("{0}: {1}", activity.Name, Lang.Res.Value_is_not_defined)){
            
        }
    }
}
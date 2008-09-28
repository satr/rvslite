namespace RVSLite{
    public class DivisionCalculationCommand : OperationsCommandBase{
        public override object Perform(object value1, object value2){
            if (Settings.ValueIsInt(value1) && Settings.ValueIsInt(value2)){
                if ((int)value2 == 0)
                    return Lang.Res.Unallowed_devision_by_zero;
                return (int) value1/(int) value2;
            }
            return Lang.Res.Undefined;
        }
        public override string ToString() {
            return "/";
        }
    }
}
namespace RVSLite{
    public class MultiplyCalculationCommand : OperationsCommandBase{
        public override object Perform(object value1, object value2){
            if (Settings.ValueIsInt(value1) && Settings.ValueIsInt(value2))
                return (int)value1 * (int)value2;
            return Lang.Res.Undefined;
        }
        public override string ToString() {
            return "*";
        }
    }
}
namespace RVSLite{
    public class SubstractionCalculationCommand : OperationsCommandBase{
        public override object Perform(object value1, object value2){
            if (Settings.ValueIsInt(value1) && Settings.ValueIsInt(value2))
                return (int)value1 - (int)value2;
            return Settings.ToString(value1).Replace(Settings.ToString(value2), string.Empty);
        }
        public override string ToString() {
            return "-";
        }
    }
}
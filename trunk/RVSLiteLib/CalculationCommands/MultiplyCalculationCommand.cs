namespace RVSLite{
    public class MultiplyCalculationCommand : CalculationCommandBase{
        public override object Calculate(object value1, object value2){
            return (int)value1 * (int)value2;

        }
        public override string ToString() {
            return "*";
        }
    }
}
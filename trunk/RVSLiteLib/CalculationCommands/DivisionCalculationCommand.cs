namespace RVSLite{
    public class DivisionCalculationCommand : CalculationCommandBase{
        public override object Calculate(IValueHolder leftValueHolder, IValueHolder rightValueHolder){
            return (int)leftValueHolder.Value / (int)rightValueHolder.Value;
        }
        public override string ToString() {
            return "/";
        }
    }
}
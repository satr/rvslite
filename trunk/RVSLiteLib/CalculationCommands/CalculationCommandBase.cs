namespace RVSLite{
    public abstract class CalculationCommandBase{
        public abstract object Calculate(IValueHolder leftValueHolder, IValueHolder rightValueHolder);
    }
}
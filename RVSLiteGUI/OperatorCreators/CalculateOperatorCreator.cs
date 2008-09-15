namespace RVSLite{
    public class CalculateOperatorCreator : OperatorCreatorBase{
        public CalculateOperatorCreator(IHardwareInterface hardware) : base(hardware) {}

        public override OperatorBase Create(){
            return new Calculate(new ValueHolder(), CalculationOperations.Sum, new ValueHolder());
        }

        public override string Name {
            get { return Calculate.OperatorName; }
        }
    }
}
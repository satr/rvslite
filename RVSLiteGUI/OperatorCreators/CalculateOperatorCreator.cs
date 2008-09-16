namespace RVSLite{
    public class CalculateOperatorCreator : ElementCreatorBase{
        public CalculateOperatorCreator(IServiceProvider services) : base(services) {}

//        public override OperatorBase Create(){
//            return new Calculate(new ValueHolder(), CalculationOperations.Sum, new ValueHolder());
//        }

        public override string Name {
            get { return Calculate.OperatorName; }
        }
    }
}
using System.Collections.Generic;

namespace RVSLite{
    public class CalculateOperatorCreator : OperatorWithOperationCreatorBase {
        public CalculateOperatorCreator(IServiceProvider services) : base(services) {}

        public override string Name {
            get { return Lang.Res.Calculate; }
        }

        public override BaseOperator Create(){
            return new Calculate(Name);
        }

        public override IEnumerable<OperationsCommandBase> OperationCommands {
            get {
                yield return new SumCalculationCommand();
                yield return new SubstractionCalculationCommand();
                yield return new MultiplyCalculationCommand();
                yield return new DivisionCalculationCommand();
            }
        }
    }
}
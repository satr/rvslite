using System.Collections.Generic;

namespace RVSLite{
    public class CalculateActivityCreator : ActivityWithOperationCreatorBase {
        public CalculateActivityCreator(IServiceProvider services) : base(services) {}

        public override string Name {
            get { return Lang.Res.Calculate; }
        }

        public override BaseActivity Create(){
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
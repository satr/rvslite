using System.Collections.Generic;
using RVSLite.Controls.ActivityControls;

namespace RVSLite{
    public class CalculateActivityCreator : ActivityWithOperationCreatorBase{
        public CalculateActivityCreator(IServiceProvider services) : base(services){
        }

        public override string Name{
            get { return Lang.Res.Calculate; }
        }

        public override IEnumerable<OperationsCommandBase> OperationCommands{
            get{
                yield return new SumCalculationCommand();
                yield return new SubstractionCalculationCommand();
                yield return new MultiplyCalculationCommand();
                yield return new DivisionCalculationCommand();
            }
        }

        public override BaseActivity Create(){
            return new CalculateActivity(Name);
        }

        protected override IActivityControl CreateActivityControl(){
            return new ActivityWithOperationControl{
                                                       ControlName = Lang.Res.Calculate,
                                                       ServiceProvider = ServiceProvider,
                                                       OperationCommands = OperationCommands,
                                                       Activity = Create()
                                                   };
        }
    }
}
using System.Collections.Generic;
using RVSLite.Controls.ActivityControls;

namespace RVSLite{
    public class IfClauseActivityCreator : ActivityWithOperationCreatorBase{
        public IfClauseActivityCreator(IServiceProvider services) : base(services){
        }

        public override string Name{
            get { return Lang.Res.Condition; }
        }

        public override IEnumerable<OperationsCommandBase> OperationCommands{
            get{
                yield return new EqualConditionCommand();
                yield return new GreaterThanConditionCommand();
                yield return new GreaterThanOrEqualConditionCommand();
                yield return new LessThanConditionCommand();
                yield return new LessThanOrEqualConditionCommand();
                yield return new NotEqualConditionCommand();
            }
        }

        public override BaseActivity Create(){
            return new IfClauseActivity(Name);
        }

        protected override IActivityControl CreateActivityControl(){
            return new ActivityWithOperationControl{
                                                       ControlName = Lang.Res.If,
                                                       ServiceProvider = ServiceProvider,
                                                       OperationCommands = OperationCommands,
                                                       Activity = Create()
                                                   };
        }
    }
}
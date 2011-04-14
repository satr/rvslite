using System.Collections.Generic;
using RVSLite.Controls.ActivityControls;

namespace RVSLite{
    public class IfClauseActivityFactory : ActivityWithOperationFactoryBase{
        public IfClauseActivityFactory(IServiceProvider services) : base(services){
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

        public override IActivityControl CreateActivityControl(){
            return new ActivityWithOperationControl{
                                                       ControlName = Lang.Res.If,
                                                       ServiceProvider = ServiceProvider,
                                                       OperationCommands = OperationCommands,
                                                       Activity = Create()
                                                   };
        }

        public override string FactoryKey{
            get { return "Condition"; }
        }

        protected override BaseActivity Create() {
            return new IfClauseActivity(Name) { FactoryKey = FactoryKey };
        }
    }
}
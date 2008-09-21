using System.Collections.Generic;

namespace RVSLite{
    public class IfClauseActivityCreator : ActivityWithOperationCreatorBase{
        public IfClauseActivityCreator(IServiceProvider services) : base(services) {}

        public override string Name {
            get { return Lang.Res.Condition; }
        }

        public override BaseActivity Create(){
            return new IfClause(Name);
        }

        public override IEnumerable<OperationsCommandBase> OperationCommands {
            get {
                yield return new EqualConditionCommand();
                yield return new GreaterThanConditionCommand();
                yield return new GreaterThanOrEqualConditionCommand();
                yield return new LessThanConditionCommand();
                yield return new LessThanOrEqualConditionCommand();
                yield return new NotEqualConditionCommand();
            }
        }

    }
}
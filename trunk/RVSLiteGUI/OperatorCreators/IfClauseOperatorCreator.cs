using System.Collections.Generic;

namespace RVSLite{
    public class IfClauseOperatorCreator : OperatorWithOperationCreatorBase{
        public IfClauseOperatorCreator(IServiceProvider services) : base(services) {}

        public override string Name {
            get { return Lang.Res.Condition; }
        }

        public override BaseOperator Create(){
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
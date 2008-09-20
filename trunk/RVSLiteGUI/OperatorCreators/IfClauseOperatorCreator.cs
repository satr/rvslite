namespace RVSLite{
    public class IfClauseOperatorCreator : SingleOperatorCreatorBase{
        public IfClauseOperatorCreator(IServiceProvider services) : base(services) {}

        public override string Name {
            get { return Lang.Res.Condition; }
        }

        public override BaseOperator Create(){
            return new IfClause(Name);
        }
    }
}
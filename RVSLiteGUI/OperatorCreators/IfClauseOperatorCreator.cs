namespace RVSLite{
    public class IfClauseOperatorCreator : ElementCreatorBase{
        public IfClauseOperatorCreator(IServiceProvider services) : base(services) {}

/*
        public override OperatorBase Create(){
            return new IfClause();
        }
*/

        public override string Name {
            get { return IfClause.OperatorName; }
        }
    }
}
namespace RVSLite{
    public class IfClauseOperatorCreator : OperatorCreatorBase{
        public IfClauseOperatorCreator(IHardwareInterface hardware) : base(hardware) {}

        public override OperatorBase Create(){
            return new IfClause();
        }

        public override string Name {
            get { return IfClause.OperatorName; }
        }
    }
}
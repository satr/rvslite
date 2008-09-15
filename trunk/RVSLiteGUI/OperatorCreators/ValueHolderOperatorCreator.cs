namespace RVSLite{
    public class ValueHolderOperatorCreator : OperatorCreatorBase{
        public ValueHolderOperatorCreator(IHardwareInterface hardware) : base(hardware) {}

        public override OperatorBase Create(){
            return new ValueHolder();
        }

        public override string Name {
            get { return ValueHolder.OperatorName; }
        }
    }
}
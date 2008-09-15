namespace RVSLite{
    public class DataHolderOperatorCreator : OperatorCreatorBase{
        public DataHolderOperatorCreator(IHardwareInterface hardware) : base(hardware) {}

        public override OperatorBase Create(){
            return new DataHolder(0);
        }

        public override string Name {
            get { return DataHolder.OperatorName; }
        }
    }
}
namespace RVSLite{
    public class DataHolderOperatorCreator : ElementCreatorBase{
        public DataHolderOperatorCreator(IServiceProvider services) : base(services) {}

/*
        public override OperatorBase Create(){
            return new DataHolder(0);
        }
*/

        public override string Name {
            get { return DataHolder.OperatorName; }
        }
    }
}
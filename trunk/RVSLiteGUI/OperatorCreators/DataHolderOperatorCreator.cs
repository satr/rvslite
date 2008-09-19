namespace RVSLite{
    public class DataHolderOperatorCreator : SingleOperatorCreatorBase {
        public DataHolderOperatorCreator(IServiceProvider services) : base(services) {}

        public override string Name {
            get { return Lang.Res.Data; }
        }

        protected override BaseOperator Create(){
            return new DataHolder();
        }
    }
}
namespace RVSLite{
    public class DataHolderOperatorCreator : SingleOperatorCreatorBase {
        public DataHolderOperatorCreator(IServiceProvider services) : base(services) {}

        public override string Name {
            get { return Lang.Res.Data; }
        }

        public override BaseOperator Create(){
            return new DataHolder();
        }

        public override bool RequireInitValue {
            get { return true; }
        }

        public override bool RequireSourceElement {
            get { return false; }
        }
    }
}
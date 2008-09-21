namespace RVSLite{
    public class DataActivityCreator : SingleInstanceActivityCreatorBase {
        public DataActivityCreator(IServiceProvider services) : base(services) {}

        public override string Name {
            get { return Lang.Res.Data; }
        }

        public override BaseActivity Create(){
            return new Data();
        }

        public override bool RequireInitValue {
            get { return true; }
        }

        public override bool RequireSourceElement {
            get { return false; }
        }
    }
}
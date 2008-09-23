using RVSLite.Controls.ActivityControls;

namespace RVSLite{
    public class DataActivityCreator : SingleInstanceActivityCreatorBase{
        public DataActivityCreator(IServiceProvider services) : base(services){
        }

        public override string Name{
            get { return Lang.Res.Data; }
        }

        public override bool RequireInitValue{
            get { return true; }
        }

        public override bool RequireSourceElement{
            get { return false; }
        }

        public override BaseActivity Create(){
            return new DataActivity();
        }

        protected override IActivityControl CreateActivityControl(){
            return new DataActivityControl{Activity = Create()};
        }
    }
}
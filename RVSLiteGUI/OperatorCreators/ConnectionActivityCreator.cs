using RVSLite.Controls.ActivityControls;

namespace RVSLite{
    public class ConnectionActivityCreator : SingleInstanceActivityCreatorBase {
        public ConnectionActivityCreator(IServiceProvider serviceProvider) : base(serviceProvider) {}

        public override BaseActivity Create() {
            return new ConnectionActivity(Name);
        }

        public override string Name {
            get { return Lang.Res.Connection; }
        }

        public override bool IsAnonymous{
            get { return true; }
        }

        protected override IActivityControl CreateActivityControl(){
            return new ConnectionActivityControl();
        }
    }
}
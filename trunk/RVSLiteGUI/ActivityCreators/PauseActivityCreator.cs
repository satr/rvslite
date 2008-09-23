using RVSLite.Controls;
using RVSLite.Controls.ActivityControls;

namespace RVSLite{
    public class PauseActivityCreator : SingleInstanceActivityCreatorBase{
        public PauseActivityCreator(IServiceProvider serviceProvider) : base(serviceProvider){
        }

        public override string Name{
            get { return Lang.Res.Pause; }
        }

        public override BaseActivity Create(){
            return new PauseActivity();
        }
        protected override IActivityControl CreateActivityControl() {
            return new PauseActivityControl() { Activity = Create() };
        }
    }
}
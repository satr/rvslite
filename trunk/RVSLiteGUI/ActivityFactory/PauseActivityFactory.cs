using System.Xml;
using RVSLite.Controls.ActivityControls;

namespace RVSLite{
    public class PauseActivityFactory : SingleInstanceActivityFactoryBase{
        public PauseActivityFactory(IServiceProvider serviceProvider) : base(serviceProvider){
        }

        public override string Name{
            get { return Lang.Res.Pause; }
        }

        public override IActivityControl CreateActivityControl(){
            return new PauseActivityControl{
                                               Activity = Create()
                                           };
        }

        public override string FactoryKey{
            get { return "Pause"; }
        }

        protected override BaseActivity Create(){
            return new CompositeActivityDecorator(new PauseActivity() { FactoryKey = FactoryKey });
        }
    }
}
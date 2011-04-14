using RVSLite.Controls;

namespace RVSLite{
    public class JoinActivityFactory : SingleInstanceActivityFactoryBase{
        public JoinActivityFactory(IServiceProvider serviceProvider) : base(serviceProvider){
        }

        public override string Name{
            get { return Lang.Res.Join; }
        }

        public override IActivityControl CreateActivityControl(){
            return new JoinActivityControl() { Activity = Create() };
        }

        public override string FactoryKey{
            get { return "Join"; }
        }

        protected override BaseActivity Create() {
            return new JoinActivity(Name) { FactoryKey = FactoryKey };
        }
    }
}
using RVSLite.Controls;

namespace RVSLite{
    public class JoinActivityCreator : SingleInstanceActivityCreatorBase{
        public JoinActivityCreator(IServiceProvider serviceProvider) : base(serviceProvider){
        }

        public override string Name{
            get { return Lang.Res.Join; }
        }

        public override BaseActivity Create(){
            return new JoinActivity(Name);
        }

        protected override IActivityControl CreateActivityControl(){
            return new JoinActivityControl() { Activity = Create() };
        }
    }
}
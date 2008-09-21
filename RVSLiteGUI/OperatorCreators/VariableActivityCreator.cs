using System.Collections.Generic;
using RVSLite.Controls.ActivityControls;

namespace RVSLite{
    public class VariableActivityCreator : BaseActivityCreatorBase{
        public VariableActivityCreator(IServiceProvider serviceProvider) : base(serviceProvider){
        }

        public override string Name{
            get { return Lang.Res.Variable; }
        }

        public override bool IsCollectable{
            get { return true; }
        }

        public override List<BaseActivity> Instances{
            get { return ServiceProvider.Variables; }
        }

        public override BaseActivity Create(){
            return new VariableActivity(Name);
        }

        protected override IActivityControl CreateActivityControl(){
            return new VariableActivityControl(){VariableActivityCreator = this };
        }
    }
}
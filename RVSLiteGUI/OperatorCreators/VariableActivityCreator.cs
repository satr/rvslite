using System.Collections.Generic;

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
            get { return ServiceProvider.ValueHolders; }
        }

        public override BaseActivity Create(){
            return new Variable(Name);
        }
    }
}
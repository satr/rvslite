using System.Collections.Generic;
using System.Xml;
using RVSLite.Controls.ActivityControls;

namespace RVSLite{
    public class VariableActivityFactory : BaseActivityFactoryBase{
        public VariableActivityFactory(IServiceProvider serviceProvider) : base(serviceProvider){
        }

        public override string Name{
            get { return Lang.Res.Variable; }
        }

        public override List<BaseActivity> Instances{
            get { return ServiceProvider.Variables; }
        }

        public override IActivityControl CreateActivityControl(){
            return new VariableActivityControl() { VariableActivityFactory = this };
        }

        public override string FactoryKey{
            get { return "Variable"; }
        }

        public override BaseActivity CreateActivityBy(XmlTextReader xmlTextReader){
            throw new System.NotImplementedException();
        }
    }
}
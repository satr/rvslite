using System.Windows.Forms;
using System.Xml;
using RVSLite.Controls.ActivityControls;

namespace RVSLite{
    public class CompositeActivityFactory : BaseActivityFactoryBase{
        public CompositeActivityFactory(IServiceProvider serviceProvider) : base(serviceProvider){
        }

        public override string Name{
            get { return Lang.Res.Activity; }
        }

        public override IActivityControl CreateActivityControl(){
            return new CompositeActivityControl { Activity = new CompositeActivity() { Name = Name, FactoryKey = FactoryKey } };
        }

        public override string FactoryKey{
            get { return "CompositeActivity"; }
        }

        public override BaseActivity CreateActivityBy(XmlTextReader xmlTextReader){
            throw new System.NotImplementedException();
        }
    }
}
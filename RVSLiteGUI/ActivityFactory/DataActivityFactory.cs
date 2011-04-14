using System.Xml;
using RVSLite.Controls.ActivityControls;

namespace RVSLite{
    public class DataActivityFactory : SingleInstanceActivityFactoryBase{
        public DataActivityFactory(IServiceProvider services) : base(services){
        }

        public override string Name{
            get { return Lang.Res.Data; }
        }

        public override IActivityControl CreateActivityControl(){
            return new DataActivityControl { Activity = Create() };
        }

        public override string FactoryKey{
            get { return "Data"; }
        }

        protected override BaseActivity Create(){
            return new DataActivity(){FactoryKey = FactoryKey};
        }
    }
}
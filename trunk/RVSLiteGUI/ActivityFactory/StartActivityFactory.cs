using System.Xml;
using RVSLite.Controls.ActivityControls;

namespace RVSLite{
    public class StartActivityFactory : SingleInstanceActivityFactoryBase{
        public StartActivityFactory(IServiceProvider serviceProvider) : base(serviceProvider){
        }

        public override string Name{
            get { return Lang.Res.Start; }
        }


        public override IActivityControl CreateActivityControl(){
            return new StartActivityControl{Activity = Create(Name)};
        }

        public override string FactoryKey{
            get { return "Start"; }
        }

        protected override BaseActivity Create(){
            return Create(Name);
        }

        private BaseActivity Create(string name){
            return new BaseActivity(name){FactoryKey = FactoryKey};
        }

        public override BaseActivity CreateActivityBy(XmlTextReader xmlTextReader){
            return Create(GetNameFrom(xmlTextReader)).SetId(GetIdFrom(xmlTextReader));
        }
    }
}
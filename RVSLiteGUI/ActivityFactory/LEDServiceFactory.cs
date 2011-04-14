using System.Collections.Generic;

namespace RVSLite{
    public class LEDServiceFactory : ServiceActivityFactoryBase{
        public LEDServiceFactory(IServiceProvider services) : base(services, false){
        }

        public override string Name{
            get { return Lang.Res.LED; }
        }

        public override string FactoryKey{
            get { return "LEDService"; }
        }

        protected override List<IService> GetServices(){
            return _serviceProvider.LEDPorts;
        }

        protected override void Subscribe(IService service, BaseActivity activity){
            activity.OnPost += service.SetValue;
        }
    }
}
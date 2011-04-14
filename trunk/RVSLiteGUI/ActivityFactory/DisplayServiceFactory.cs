using System.Collections.Generic;

namespace RVSLite{
    public class DisplayServiceFactory : ServiceActivityFactoryBase{
        public DisplayServiceFactory(IServiceProvider services) : base(services, true){
        }

        public override string Name{
            get { return Lang.Res.Display; }
        }

        public override string FactoryKey{
            get { return "Display"; }
        }

        protected override List<IService> GetServices(){
            return _serviceProvider.MessengerPorts;
        }

        protected override void Subscribe(IService service, BaseActivity activity){
            activity.OnPost += service.SetValue;
        }
    }
}
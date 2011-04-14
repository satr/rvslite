using System.Collections.Generic;

namespace RVSLite{
    public class BumperServiceFactory : ServiceActivityFactoryBase{
        public BumperServiceFactory(IServiceProvider services) : base(services, true){
        }

        public override string Name{
            get { return Lang.Res.Bumper; }
        }

        public override string FactoryKey{
            get { return "BumperService"; }
        }

        protected override List<IService> GetServices(){
            return _serviceProvider.BumperPorts;
        }

        protected override void Subscribe(IService service, BaseActivity activity){
            service.OnStateChanged += activity.Post;
        }
    }
}
using System.Collections.Generic;

namespace RVSLite{
    public class DriveServiceFactory : ServiceActivityFactoryBase{
        public DriveServiceFactory(IServiceProvider services) : base(services, false){
        }

        public override string Name{
            get { return Lang.Res.Drive; }
        }

        public override string FactoryKey{
            get { return "DriveService"; }
        }

        protected override List<IService> GetServices(){
            return _serviceProvider.DrivePorts;
        }

        protected override void Subscribe(IService service, BaseActivity activity){
            activity.OnPost += service.SetValue;
        }
    }
}
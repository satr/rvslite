using System.Collections.Generic;

namespace RVSLite{
    public class DriveServiceCreator : ServiceActivityCreatorBase{
        public DriveServiceCreator(IServiceProvider services) : base(services, false){
        }

        public override string Name{
            get { return Lang.Res.Drive; }
        }

        protected override List<IService> GetServices(){
            return _serviceProvider.DrivePorts;
        }

        protected override void Subscribe(IService service, BaseActivity activity){
            activity.OnPost += service.SetValue;
        }
    }
}
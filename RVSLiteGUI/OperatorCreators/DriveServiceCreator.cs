using System.Collections;
using RVSLite.Controls.ActivityControls;

namespace RVSLite{
    public class DriveServiceCreator :ServiceCreatorBase {
        public DriveServiceCreator(IServiceProvider services) : base(services) {}

        public override string Name {
            get { return DriveService.OperatorName; }
        }

        protected override IList GetServices(){
            return _serviceProvider.DrivePorts;
        }

        protected override void Subscribe(IService service, BaseActivity oper) {
            oper.OnPost += service.SetValue;
        }

        public override BaseActivity Create(){
            return new DriveService();
        }
        protected override IActivityControl CreateActivityControl() {
            return new ServiceControl() { ControlName = Lang.Res.Drive, Ports = _serviceProvider.DrivePorts };
        }
    }
}
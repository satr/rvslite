using System.Collections;

namespace RVSLite{
    public class DriveServiceCreator :ServiceCreatorBase {
        public DriveServiceCreator(IServiceProvider services) : base(services) {}

        public override string Name {
            get { return Drive.OperatorName; }
        }

        protected override IList GetServices(){
            return _serviceProvider.DrivePorts;
        }

        protected override void Subscribe(IService service, BaseActivity oper) {
            oper.OnPost += service.SetValue;
        }

        public override BaseActivity Create(){
            return new Drive();
        }
    }
}
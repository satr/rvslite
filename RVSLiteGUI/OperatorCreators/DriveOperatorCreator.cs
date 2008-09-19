using System.Collections;

namespace RVSLite{
    public class DriveOperatorCreator :ServiceCreatorBase {
        public DriveOperatorCreator(IServiceProvider services) : base(services) {}

        public override string Name {
            get { return Drive.OperatorName; }
        }

        protected override IList GetServices(){
            return _serviceProvider.DrivePorts;
        }

        protected override void Subscribe(IService service, BaseOperator oper) {
            oper.OnPost += service.SetValue;
        }

        protected override BaseOperator CreateOperator(){
            return new Drive();
        }
    }
}
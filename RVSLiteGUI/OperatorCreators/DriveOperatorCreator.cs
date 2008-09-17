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

        protected override void Subscribe(IValueHolder service, OperatorBase oper) {
            oper.OnPost += service.SetValue;
        }

        protected override OperatorBase CreateOperator(){
            return new Drive();
        }
    }
}
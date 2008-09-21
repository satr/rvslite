using System.Collections;

namespace RVSLite{
    public class LEDServiceCreator : ServiceCreatorBase{
        public LEDServiceCreator(IServiceProvider services) : base(services){
        }

        public override string Name {
            get { return LED.OperatorName; }
        }

        protected override IList GetServices(){
            return _serviceProvider.LEDPorts;
        }

        public override BaseActivity Create(){
            return new LED();
        }

        protected override void Subscribe(IService service, BaseActivity oper) {
            oper.OnPost += service.SetValue;
        }
    }
}
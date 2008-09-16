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

        protected override OperatorBase CreateOperator(){
            return new LED();
        }

        protected override void Subscribe(IBooleanValue service, OperatorBase oper){
            oper.OnPost += service.SetValue;
        }
    }
}
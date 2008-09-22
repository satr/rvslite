using System.Collections;
using RVSLite.Controls.ActivityControls;

namespace RVSLite{
    public class LEDServiceCreator : ServiceCreatorBase{
        public LEDServiceCreator(IServiceProvider services) : base(services){
        }

        public override string Name {
            get { return LEDService.OperatorName; }
        }

        protected override IList GetServices(){
            return _serviceProvider.LEDPorts;
        }

        public override BaseActivity Create(){
            return new LEDService();
        }

        protected override void Subscribe(IService service, BaseActivity oper) {
            oper.OnPost += service.SetValue;
        }

        protected override IActivityControl CreateActivityControl(){
            return new ServiceControl{ControlName = Lang.Res.LED,Ports = _serviceProvider.LEDPorts};
        }
    }
}
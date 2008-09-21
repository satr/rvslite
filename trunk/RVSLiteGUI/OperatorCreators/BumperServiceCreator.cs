using System.Collections;
using RVSLite.Controls.ActivityControls;

namespace RVSLite{
    public class BumperServiceCreator : ServiceCreatorBase{
        public BumperServiceCreator(IServiceProvider services) : base(services){
        }

        protected override IList GetServices(){
            return _serviceProvider.BumperPorts;
        }

        public override string Name{
            get { return BumperService.OperatorName; }
        }

        public override BaseActivity Create(){
            return new BumperService();
        }

        protected override void Subscribe(IService service, BaseActivity oper){
            service.OnStateChanged += oper.Post;
        }

        public override bool RequireSourceElement {
            get { return false; }
        }

        protected override IActivityControl CreateActivityControl(){
            return new BumperServiceControl(){Ports = _serviceProvider.BumperPorts};
        }
    }
}
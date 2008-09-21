using System.Collections;

namespace RVSLite{
    public class BumperServiceCreator : ServiceCreatorBase{
        public BumperServiceCreator(IServiceProvider services) : base(services){
        }

        protected override IList GetServices(){
            return _serviceProvider.BumperPorts;
        }

        public override string Name{
            get { return Bumper.OperatorName; }
        }

        public override BaseActivity Create(){
            return new Bumper();
        }

        protected override void Subscribe(IService service, BaseActivity oper){
            service.OnStateChanged += oper.Post;
        }

        public override bool RequireSourceElement {
            get { return false; }
        }
    }
}
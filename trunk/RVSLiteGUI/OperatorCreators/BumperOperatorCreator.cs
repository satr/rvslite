using System.Collections;

namespace RVSLite{
    public class BumperOperatorCreator : ServiceCreatorBase{
        public BumperOperatorCreator(IServiceProvider services) : base(services){
        }

        protected override IList GetServices(){
            return _serviceProvider.BumperPorts;
        }

        public override string Name{
            get { return Bumper.OperatorName; }
        }

        public override BaseOperator Create(){
            return new Bumper();
        }

        protected override void Subscribe(IService service, BaseOperator oper){
            service.OnStateChanged += oper.Post;
        }

        public override bool RequireSourceElement {
            get { return false; }
        }
    }
}
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

        protected override OperatorBase CreateOperator(){
            return new Bumper();
        }

        protected override void Subscribe(IBooleanValue service, OperatorBase oper){
            service.OnStateChanged += oper.Post;
        }
    }
}
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

        protected override BaseOperator CreateOperator(){
            return new Bumper();
        }

        protected override void Subscribe(IService service, BaseOperator oper){
            service.OnStateChanged += oper.Post;
        }
    }
}
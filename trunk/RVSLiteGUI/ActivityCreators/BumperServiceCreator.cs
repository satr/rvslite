using System.Collections.Generic;

namespace RVSLite{
    public class BumperServiceCreator : ServiceActivityCreatorBase{
        public BumperServiceCreator(IServiceProvider services) : base(services, true){
        }

        public override string Name{
            get { return Lang.Res.Bumper; }
        }

        public override bool RequireSourceElement{
            get { return false; }
        }

        protected override List<IService> GetServices(){
            return _serviceProvider.BumperPorts;
        }

        protected override void Subscribe(IService service, BaseActivity activity){
            service.OnStateChanged += activity.Post;
        }
    }
}
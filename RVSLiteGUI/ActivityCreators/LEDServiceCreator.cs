using System.Collections.Generic;

namespace RVSLite{
    public class LEDServiceCreator : ServiceActivityCreatorBase{
        public LEDServiceCreator(IServiceProvider services) : base(services, false){
        }

        public override string Name{
            get { return Lang.Res.LED; }
        }

        protected override List<IService> GetServices(){
            return _serviceProvider.LEDPorts;
        }

        protected override void Subscribe(IService service, BaseActivity activity){
            activity.OnPost += service.SetValue;
        }
    }
}
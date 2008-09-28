using System.Collections.Generic;

namespace RVSLite{
    public class MessengerServiceCreator : ServiceActivityCreatorBase{
        public MessengerServiceCreator(IServiceProvider services) : base(services, true){
        }

        public override string Name{
            get { return Lang.Res.Messenger; }
        }

        protected override List<IService> GetServices(){
            return _serviceProvider.MessengerPorts;
        }

        protected override void Subscribe(IService service, BaseActivity activity){
            activity.OnPost += service.SetValue;
        }
    }
}
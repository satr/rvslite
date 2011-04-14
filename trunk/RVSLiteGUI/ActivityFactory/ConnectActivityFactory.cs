using RVSLite.Controls.ActivityControls;

namespace RVSLite{
    public class ConnectActivityFactory : SingleInstanceActivityFactoryBase {
        public ConnectActivityFactory(IServiceProvider serviceProvider) : base(serviceProvider) {}

        public override string Name {
            get { return Lang.Res.Connection; }
        }

        public override IActivityControl CreateActivityControl(){
            return new ConnectionActivityControl(){Activity = Create()};
        }

        public override string FactoryKey{
            get { return "Connect"; }
        }

        protected override BaseActivity Create(){
            return new ConnectActivity(Name) { FactoryKey = FactoryKey };
        }
    }
}
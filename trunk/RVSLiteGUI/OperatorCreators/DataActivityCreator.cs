using System.Windows.Forms;
using RVSLite.Controls;
using RVSLite.Controls.ActivityControls;

namespace RVSLite{
    public class DataActivityCreator : SingleInstanceActivityCreatorBase {
        public DataActivityCreator(IServiceProvider services) : base(services) {}

        public override string Name {
            get { return Lang.Res.Data; }
        }

        public override BaseActivity Create(){
            return new DataActivity();
        }

        public override bool RequireInitValue {
            get { return true; }
        }

        public override bool RequireSourceElement {
            get { return false; }
        }

        protected override IActivityControl CreateActivityControl(){
            return new DataActivityControl();
        }
    }
}
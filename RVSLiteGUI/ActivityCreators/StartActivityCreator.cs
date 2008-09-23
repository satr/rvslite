using System;
using System.Collections.Generic;
using System.Text;
using RVSLite.Controls.ActivityControls;

namespace RVSLite {
    public class StartActivityCreator : SingleInstanceActivityCreatorBase {
        public StartActivityCreator(IServiceProvider serviceProvider) : base(serviceProvider){
        }

        public override string Name{
            get { return Lang.Res.Start; }
        }

        public override BaseActivity Create(){
            return new BaseActivity(Name);
        }

        protected override IActivityControl CreateActivityControl(){
            return new StartActivityControl(){Activity = Create()};
        }
    }
}

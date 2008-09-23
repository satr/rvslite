using System.Collections;
using System.Collections.Generic;

namespace RVSLite{
    public abstract class SingleInstanceActivityCreatorBase : BaseActivityCreatorBase{
        protected SingleInstanceActivityCreatorBase(IServiceProvider serviceProvider) : base(serviceProvider) {
        }

        public override List<BaseActivity> Instances{
            get{
                _instances.Clear();
                _instances.Add(Create());
                return _instances;
            }
        }


    }
}
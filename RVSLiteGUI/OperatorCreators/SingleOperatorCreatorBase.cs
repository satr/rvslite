using System.Collections;
using System.Collections.Generic;

namespace RVSLite{
    public abstract class SingleOperatorCreatorBase : OperatorCreatorBase{
        protected SingleOperatorCreatorBase(IServiceProvider serviceProvider) : base(serviceProvider) {
        }

        public override List<BaseOperator> Instances{
            get{
                _instances.Clear();
                _instances.Add(Create());
                return _instances;
            }
        }


    }
}
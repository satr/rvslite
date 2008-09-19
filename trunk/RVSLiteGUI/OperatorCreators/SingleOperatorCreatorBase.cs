using System.Collections;

namespace RVSLite{
    public abstract class SingleOperatorCreatorBase : OperatorCreatorBase{
        protected SingleOperatorCreatorBase(IServiceProvider serviceProvider) : base(serviceProvider) {
        }

        public override IList Instances{
            get{
                _instances.Clear();
                _instances.Add(Create());
                return _instances;
            }
        }
    }
}
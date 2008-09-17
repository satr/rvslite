using System.Collections;
using RVSLite.Controls;

namespace RVSLite{
    public abstract class ElementCreatorBase{
        protected IList _instances = new ArrayList();
        protected readonly IServiceProvider _serviceProvider;
        private OperatorHolderControl _sourceOperatorHolderControl;

        protected ElementCreatorBase(IServiceProvider serviceProvider){
            _serviceProvider = serviceProvider;
        }

        public abstract string Name { get; }

        public virtual IList Instances{
            get { return _instances; }
        }

        public IList GetInstancesBy(OperatorHolderControl sourceOperatorHolderControl){
            _sourceOperatorHolderControl = sourceOperatorHolderControl;
            return Instances;
        }
    }
}
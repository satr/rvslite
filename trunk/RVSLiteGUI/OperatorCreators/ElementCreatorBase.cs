using System.Collections;

namespace RVSLite{
    public abstract class ElementCreatorBase{
        protected IList _instances = new ArrayList();
        protected readonly IServiceProvider _serviceProvider;

        protected ElementCreatorBase(IServiceProvider serviceProvider){
            _serviceProvider = serviceProvider;
        }

        public abstract string Name { get; }

        public virtual IList Instances{
            get { return _instances; }
        }
    }
}
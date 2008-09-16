using System.Collections;

namespace RVSLite{
    public abstract class OperatorCreatorBase : ElementCreatorBase{
        protected OperatorCreatorBase(IServiceProvider serviceProvider) : base(serviceProvider) {
        }

        public override IList Instances{
            get{
                var instances = base.Instances;
                AddNewInstanceIfNotExist(instances);
                return instances;
            }
        }

        private void AddNewInstanceIfNotExist(IList instances){
            if (instances.Count == 0
                || ElementIsNotNew(instances[0]))
                instances.Insert(0,Create());
        }

        protected abstract OperatorBase Create();

        private bool ElementIsNotNew(object obj){
            foreach (var instance in _instances){
                if (instance == obj)
                    return true;
            }
            return false;
        }
    }
}
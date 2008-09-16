using System.Collections;

namespace RVSLite{
    public abstract class ServiceCreatorBase : ElementCreatorBase{
        protected object _selectedPort;

        protected ServiceCreatorBase(IServiceProvider services) : base(services){
            InitServices();
        }

        private void InitServices(){
            foreach (IBooleanValue service in GetServices())
                _instances.Add(Create(service));
            _selectedPort = _instances[0];
        }

        protected abstract IList GetServices();

        protected OperatorBase Create(IBooleanValue service){
            var oper = CreateOperator();
            Subscribe(service, oper);
            return oper;
        }

        protected abstract void Subscribe(IBooleanValue service, OperatorBase oper);

        protected abstract OperatorBase CreateOperator();
    }
}
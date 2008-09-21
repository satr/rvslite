using System.Collections;

namespace RVSLite{
    public abstract class ServiceCreatorBase : ActivityCreatorBase{
        protected object _selectedPort;

        protected ServiceCreatorBase(IServiceProvider services) : base(services){
            InitServices();
        }

        private void InitServices(){
            foreach (IService service in GetServices())
                _instances.Add(Create(service));
            _selectedPort = _instances[0];
        }

        protected abstract IList GetServices();

        protected BaseActivity Create(IService service) {
            var oper = Create();
            Subscribe(service, oper);
            return oper;
        }

        protected abstract void Subscribe(IService service, BaseActivity oper);

        public override bool IsPredefinedList{
            get { return true; }
        }
    }
}
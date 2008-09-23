namespace RVSLite{
    public class ServiceActivity : BaseActivity{
        private IService _port;

        public ServiceActivity(string name) : base(name){
        }

        public IService Port{
            get { return _port; }
            set{
                if (_port != null)
                    _port.OnStateChanged -= _port_OnStateChanged;
                _port = value;
                if (_port != null)
                    _port.OnStateChanged += _port_OnStateChanged;
            }
        }

        public override void Post(object value){
            if (Port != null)
                Port.SetValue(value);
            FireOnPost(value);
        }

        private void _port_OnStateChanged(object value){
            FireOnPost(value);
        }
    }
}
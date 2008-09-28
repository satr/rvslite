namespace RVSLite{
    public delegate void ValueEventHandler(object value);
    public delegate void ActionEventHandler();

    public class BaseActivity{
        protected readonly bool _canFirePost = true;
        private string _name;

        public BaseActivity() 
            : this(string.Empty, true){
        }

        public BaseActivity(bool canFirePost)
            : this(string.Empty, canFirePost){
        }

        public BaseActivity(string name, bool canFirePost){
            _name = name;
            _canFirePost = canFirePost;
        }

        public BaseActivity(string name) : this(name, true){
        }

        public virtual string Name{
            get { return _name; }
            set { _name = value; }
        }

        public virtual bool IsVariable{
            get { return false; }
        }

        public virtual bool IsOperatorWithOperation{
            get { return false; }
        }

        public virtual bool CanFirePost{
            get { return _canFirePost; }
        }

        public event ValueEventHandler OnPost;
        public event ActionEventHandler OnActivated;
        public event ActionEventHandler OnDeactivated;

        public virtual void Post(object value){
            FireOnPost(value);
        }

        protected void FireOnPost(object value){
            if (!CanFirePost)
                return;
            if (OnActivated != null)
                OnActivated();
            if (OnPost != null)
                OnPost(value);
            if (OnDeactivated != null)
                OnDeactivated();
        }

        public virtual string ToString(object value){
            return string.Format("{0} {1}", Name ?? string.Empty, value ?? string.Empty);
        }
    }
}
using System;

namespace RVSLite {
    public delegate void ValueEventHandler(object value);

    public class BaseActivity {
        private BaseActivity _sourceActivity;
        private string _name;
        
        public virtual string Name{
            get { return _name; }
            set { _name = value; }
        }

        public event ValueEventHandler OnPost;

        public BaseActivity(){
        }

        public BaseActivity(string name){
            _name = name;
        }

        public virtual void Post(object value){
            FireOnPost(value);
        }

        protected void FireOnPost(object value){
            if (OnPost != null)
                OnPost(value);
        }

        public BaseActivity SourceActivity{
            set{
                if (_sourceActivity != null)
                    _sourceActivity.OnPost -= Post;
                _sourceActivity = value;
                if (_sourceActivity != null)
                    _sourceActivity.OnPost += Post;
            }
            get{
                return _sourceActivity ?? (_sourceActivity = new NullActivity());
            }
        }

        public void Disconnect(){
            if (_sourceActivity == null)
                return;
            _sourceActivity.OnPost -= Post;
            _sourceActivity = null;
            Console.Out.WriteLine("{0} {1}", this, Lang.Res.Is_disconnected);
        }

        public virtual void ListenTo(BaseActivity sourceActivity) {
            SourceActivity = sourceActivity;
        }

        public virtual string ToString(object value){
            return string.Format("{0} {1}", Name ?? string.Empty, value ?? string.Empty);
        }

        public virtual bool IsVariable {
            get { return false; }
        }

        public virtual bool IsOperatorWithOperation {
            get { return false; }
        }
    }

    public class NullActivity : BaseActivity{
        public NullActivity()
            : base(Lang.Res.Undefined) {
        }

        public override void Post(object value){
            //do nothing
        }
    }
}
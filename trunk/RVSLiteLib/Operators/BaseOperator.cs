using System;

namespace RVSLite {
    public delegate void ValueEventHandler(object value);

    public class BaseOperator {
        private BaseOperator _sourceOperator;
        private string _name;
        
        public virtual string Name{
            get { return _name; }
            set { _name = value; }
        }

        public event ValueEventHandler OnPost;

        public BaseOperator(){
        }

        public BaseOperator(string name){
            _name = name;
        }

        public virtual void Post(object value){
            DisplayThis(value);
            FireOnPost(value);
        }

        protected void DisplayThis(object value){
            Console.Out.WriteLine(ToString(value));
        }

        protected void FireOnPost(object value){
            if (OnPost != null)
                OnPost(value);
        }

        public BaseOperator SourceOperator{
            set{
                _sourceOperator = value;
                _sourceOperator.OnPost += Post;
            }
            get { return _sourceOperator; }
        }

        public void Disconnect(){
            if (_sourceOperator == null)
                return;
            _sourceOperator.OnPost -= Post;
            _sourceOperator = null;
            Console.Out.WriteLine("{0} {1}", this, Lang.Res.Is_disconnected);
        }

        public virtual void ListenTo(BaseOperator sourceOperator) {
            SourceOperator = sourceOperator;
        }

        public virtual string ToString(object value){
            return string.Format("{0} {1}", Name ?? string.Empty, value ?? string.Empty);
        }
    }
}
using System;

namespace RVSLite {
    public delegate void PostEventHandler(object value);
    public delegate void BooleanEventHandler(bool value);

    public abstract class OperatorBase {
        private OperatorBase _sourceOperator;
        public abstract string Name { get; }
        public event PostEventHandler OnPost;

        public virtual void Post(object value){
            DisplayThis();
            FireOnPost(value);
        }

        protected void DisplayThis(){
            Console.Out.WriteLine(this);
        }

        protected void FireOnPost(object value){
            if (OnPost != null)
                OnPost(value);
        }

        public OperatorBase SourceOperator{
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

        public virtual void ListenTo(OperatorBase sourceOperator) {
            SourceOperator = sourceOperator;
        }
    }
}
using System;

namespace RVSLite {
    public class Messenger : ValueHolderContainerBase, IValueHolder {
        private readonly string _title;

        public Messenger(IValueHolder valueHolder) : this(Lang.Res.Message, valueHolder) { }
        public Messenger() : this(Lang.Res.Message) { }

        public Messenger(string title, IValueHolder valueHolder): this(title){
            _valueHolder = valueHolder;
        }

        public Messenger(string title) {
            _title = title;
        }

        public override string ToString() {
            return string.Format("{0}: {1}", _title, _valueHolder);
        }

        public override string Name {
            get { return Lang.Res.Messenger; }
        }

        public object Value{
            get { return _valueHolder.Value; }
            set {  }
        }
    }
}
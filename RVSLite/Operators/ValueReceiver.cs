using System;

namespace RVSLite{
    public class ValueReceiver : ValueHolder{
        protected string _title;

        public ValueReceiver()
            : this(Lang.Res.Value) {
        }

        public ValueReceiver(string title){
            _title = title;
        }

        public override string Name{
            get { return Lang.Res.Value_receiver; }
        }

        private string Prompt {
            get { return string.Format("{0} {1}{2}:", Lang.Res.Wait_for, _title, Range);}
        }

        protected virtual string Range{
            get { return string.Empty; }
        }

        public override void Post() {
            ReceiveValue();
            base.Post();
        }

        protected virtual void ReceiveValue(){
            Console.Out.Write(Prompt);
            Value = Console.In.ReadLine();
        }
    }
}
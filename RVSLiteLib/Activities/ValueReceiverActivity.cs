using System;

namespace RVSLite{
    public class ValueReceiverActivity : VariableActivity{
        new public static readonly string OperatorName = Lang.Res.Value_receiver;
        protected string _title;

        public ValueReceiverActivity()
            : this(Lang.Res.Value) {
        }

        public ValueReceiverActivity(string title){
            _title = title;
        }

        public override string Name{
            get { return OperatorName; }
        }

        private string Prompt {
            get { return string.Format("{0} {1}{2}:", Lang.Res.Wait_for, _title, Range);}
        }

        protected virtual string Range{
            get { return string.Empty; }
        }

        public override void Post(object value) {
            Value = value;
            ReceiveValue();
            base.Post(Value);
        }

        protected virtual void ReceiveValue(){
            Console.Out.Write(Prompt);
            Value = Console.In.ReadLine();
        }
    }
}
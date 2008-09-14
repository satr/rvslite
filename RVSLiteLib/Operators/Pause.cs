using System;
using System.Threading;

namespace RVSLite{
    public class Pause : ValueHolderContainerBase{
        public static readonly string OperatorName = Lang.Res.Pause;
        public Pause(int milliseconds)
            : this(new ValueHolder(milliseconds)) {
        }

        public Pause(IValueHolder valueHolder) : base(valueHolder){
        }

        public override string Name{
            get { return OperatorName; }
        }

        public override void Post(){
            DisplayThis();
            Thread.Sleep(DurationInMilliseconds);
            FireOnPost();
        }

        public override string ToString(){
            var durationText = new DateTime()
                .AddMilliseconds(DurationInMilliseconds)
                .ToString("HH:mm ss.fff");
            return string.Format("{0}: {1}", Name, durationText);
        }

        private int DurationInMilliseconds{
            get{
                int duration;
                int.TryParse(_valueHolder.Value == null ? "0" : _valueHolder.Value.ToString(), out duration);
                return duration;
            }
        }
    }
}
using System;
using System.Threading;

namespace RVSLite{
    public class PauseActivity : BaseActivity{
        public static readonly string OperatorName = Lang.Res.Pause;
        public override string Name{
            get { return OperatorName; }
            set {  }
        }

        public override void Post(object value){
            Thread.Sleep(GetDurationInMillisecondsBy(value?? 0));
            FireOnPost(value);
        }

        public override string ToString(object value){
            var durationText = new DateTime()
                .AddMilliseconds(GetDurationInMillisecondsBy(value))
                .ToString("HH:mm ss.fff");
            return string.Format("{0}: {1}", Name, durationText);
        }

        private static int GetDurationInMillisecondsBy(object value){
            int duration;
            int.TryParse(value == null ? "0" : value.ToString(), out duration);
            return duration;
        }
    }
}
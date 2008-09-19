using System;

namespace RVSLite {
    public class ClearDisplay : BaseOperator {
        public override string Name{
            get { return Lang.Res.Clear_display; }
            set { }
        }

        public override void Post(object value) {
            Console.Clear();
            FireOnPost(value);
        }
    }
}
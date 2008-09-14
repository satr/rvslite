using System;

namespace RVSLite {
    public class ClearDisplay : OperatorBase {
        public override string Name {
            get { return Lang.Res.Clear_display; }
        }

        public override void Post() {
            Console.Clear();
            FireOnPost();
        }
    }
}
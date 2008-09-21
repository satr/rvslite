using System;

namespace RVSLite {
    public class Messenger : BaseActivity {
        public static readonly string OperatorName = Lang.Res.Messenger;

        public override string Name{
            get { return OperatorName; }
            set { }
        }
    }
}
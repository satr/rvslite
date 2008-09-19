using System;

namespace RVSLite {
    public class Messenger : BaseOperator {
        public static readonly string OperatorName = Lang.Res.Messenger;

        public override string Name{
            get { return OperatorName; }
            set { }
        }
    }
}
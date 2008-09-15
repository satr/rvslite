namespace RVSLite {
    public class Connection : OperatorBase {
        public static readonly string OperatorName = Lang.Res.Connection;

        public override string Name {
            get { return OperatorName; }
        }

        public override void Post(object value) {
            FireOnPost(value);
        }
    }
}
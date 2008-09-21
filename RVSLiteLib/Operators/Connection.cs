namespace RVSLite {
    public class Connection : BaseActivity {
        public static readonly string OperatorName = Lang.Res.Connection;

        public override string Name{
            get { return OperatorName; }
            set { }
        }

        public override void Post(object value) {
            FireOnPost(value);
        }
    }
}
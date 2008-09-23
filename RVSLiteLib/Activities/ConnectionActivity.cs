namespace RVSLite {
    public class ConnectionActivity : BaseActivity {
        public ConnectionActivity(string name) : base(name){
        }

        public override void Post(object value) {
            FireOnPost(value);
        }
    }
}
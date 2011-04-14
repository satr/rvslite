namespace RVSLite {
    public class ConnectActivity : BaseActivity {
        public ConnectActivity(string name) : base(name){
        }

        public override void Post(object value) {
            FireOnPost(value);
        }
    }
}
namespace RVSLite{
    public class JoinActivity: BaseActivity{
        public JoinActivity(string name) : base(name){
        }
        public override void Post(object value){
           FireOnPost(value);
        }
    }
}
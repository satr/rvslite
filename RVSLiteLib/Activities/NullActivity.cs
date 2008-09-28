namespace RVSLite{
    public class NullActivity : BaseActivity{
        public NullActivity()
            : base(Lang.Res.Undefined) {
        }

        public override void Post(object value){
            //do nothing
        }
    }
}
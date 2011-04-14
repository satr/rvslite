namespace RVSLite{
    public class NullActivity : BaseActivity{
        public NullActivity()
            : base(Lang.Res.Undefined) {
            ID = string.Empty;
        }

        public override void Post(object value){
            //do nothing
        }
    }
}
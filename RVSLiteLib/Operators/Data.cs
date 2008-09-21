namespace RVSLite{
    public class Data : Variable{
        public Data()
            : base(Lang.Res.Constant) {
        }

        public override void Post(object value){
            base.Post(Value);
        }

        public override bool RequireInitValue{
            get { return true; }
        }
    }
}
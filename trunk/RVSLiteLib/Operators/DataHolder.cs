namespace RVSLite{
    public class DataHolder : ValueHolder{
        public DataHolder()
            : base(Lang.Res.Constant) {
        }

        public override void Post(object value){
            base.Post(Value);
        }
    }
}
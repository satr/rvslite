namespace RVSLite{
    public class DataActivity : VariableActivity{
        public DataActivity()
            : base(Lang.Res.Data) {
        }

        public override void Post(object value){
            base.Post(Value);
        }

        public override bool RequireInitValue{
            get { return true; }
        }

        public override bool IsVariable{
            get { return false; }
        }
    }
}
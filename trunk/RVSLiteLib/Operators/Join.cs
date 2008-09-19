namespace RVSLite{
    public class Join: BaseOperator{
        public static readonly string OperatorName = Lang.Res.Join;
        public override string Name{
            get { return OperatorName; }
            set {  }
        }

        public override void Post(object value){
           FireOnPost(value);
        }
    }
}
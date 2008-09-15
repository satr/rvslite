namespace RVSLite{
    public class Join: OperatorBase{
        public static readonly string OperatorName = Lang.Res.Join;
        public override string Name{
            get { return OperatorName; }
        }

        public override void Post(object value){
           FireOnPost(value);
        }
    }
}
namespace RVSLite{
    public class Join: OperatorBase{
        public override string Name{
            get { return Lang.Res.Join; }
        }

        public override void Post(){
           FireOnPost();
        }
    }
}
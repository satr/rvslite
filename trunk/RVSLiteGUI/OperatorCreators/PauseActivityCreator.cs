namespace RVSLite{
    public class PauseActivityCreator : SingleInstanceActivityCreatorBase{
        public PauseActivityCreator(IServiceProvider serviceProvider) : base(serviceProvider){
        }

        public override string Name{
            get { return Lang.Res.Pause; }
        }

        public override BaseActivity Create(){
            return new Pause();
        }
    }
}
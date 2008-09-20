namespace RVSLite{
    public class PauseOperatorCreator : SingleOperatorCreatorBase{
        public PauseOperatorCreator(IServiceProvider serviceProvider) : base(serviceProvider){
        }

        public override string Name{
            get { return Lang.Res.Pause; }
        }

        public override BaseOperator Create(){
            return new Pause();
        }
    }
}
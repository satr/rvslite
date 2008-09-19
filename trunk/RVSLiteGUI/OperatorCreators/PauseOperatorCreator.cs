namespace RVSLite{
    public class PauseOperatorCreator : SingleOperatorCreatorBase{
        public PauseOperatorCreator(IServiceProvider serviceProvider) : base(serviceProvider){
        }

        public override string Name{
            get { return Lang.Res.Pause; }
        }

        protected override BaseOperator Create(){
            return new Pause();
        }
    }
}
namespace RVSLite{
    public class CalculateOperatorCreator : SingleOperatorCreatorBase{
        public CalculateOperatorCreator(IServiceProvider services) : base(services) {}

        public override string Name {
            get { return Lang.Res.Calculate; }
        }

        public override BaseOperator Create(){
            return new Calculate(Name);
        }
    }
}
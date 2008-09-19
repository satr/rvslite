namespace RVSLite{
    public class ValueHolderOperatorCreator : OperatorCreatorBase {
        public ValueHolderOperatorCreator(IServiceProvider services) : base(services) {}

        protected override BaseOperator Create(){
            return new ValueHolder(Name);
        }

        public override string Name {
            get { return Lang.Res.Value; }
        }
    }
}
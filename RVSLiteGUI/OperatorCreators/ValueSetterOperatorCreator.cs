namespace RVSLite{
    public class ValueSetterOperatorCreator : OperatorCreatorBase{
        public ValueSetterOperatorCreator(IHardwareInterface hardware) : base(hardware) {}

        public override OperatorBase Create(){
            return new ValueSetter(new ValueHolder(), new ValueHolder());
        }

        public override string Name {
            get { return ValueSetter.OperatorName; }
        }
    }
}
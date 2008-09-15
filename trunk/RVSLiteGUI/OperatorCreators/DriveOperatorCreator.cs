namespace RVSLite{
    public class DriveOperatorCreator : OperatorCreatorBase{
        public DriveOperatorCreator(IHardwareInterface hardware) : base(hardware) {}

        public override OperatorBase Create(){
            return new Drive();
        }

        public override string Name {
            get { return Drive.OperatorName; }
        }
    }
}
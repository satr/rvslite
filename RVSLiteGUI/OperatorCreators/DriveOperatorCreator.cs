namespace RVSLite{
    public class DriveOperatorCreator : ElementCreatorBase{
        public DriveOperatorCreator(IServiceProvider services) : base(services) {}

//        public override OperatorBase Create(){
//            return new Drive();
//        }

        public override string Name {
            get { return Drive.OperatorName; }
        }
    }
}
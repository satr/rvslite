namespace RVSLite{
    public class BumperOperatorCreator : OperatorCreatorBase{
        private IBooleanValue _selectedBumper;

        public BumperOperatorCreator(IHardwareInterface hardware) : base(hardware){
            _selectedBumper = Bumpers[0];
        }

        public override OperatorBase Create(){
            var bumper = new Bumper();
//            _selectedBumper.OnStateChanged += bumper.Post;
            return bumper;
        }

        public override string Name {
            get { return Bumper.OperatorName; }
        }

        public IBooleanValue[] Bumpers {
            get { return _hardware.Bumpers; }
        }
    }
}
namespace RVSLite{
    public class HardwareInterface : IHardwareInterface{
        private readonly ITriggerValue _bumper1;
        private readonly ITriggerValue _led1;

        public HardwareInterface(ITriggerValue bumper1, ITriggerValue led1){
            _bumper1 = bumper1;
            _led1 = led1;
        }

        #region IHardwareInterface Members

        public ITriggerValue Bumper1{
            get { return _bumper1; }
        }

        public ITriggerValue Led1{
            get { return _led1; }
        }

        #endregion
    }
}
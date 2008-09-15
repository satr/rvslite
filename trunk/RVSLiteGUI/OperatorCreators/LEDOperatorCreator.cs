namespace RVSLite{
    public class LEDOperatorCreator : OperatorCreatorBase{
        private IBooleanValue _selectedLED;

        public LEDOperatorCreator(IHardwareInterface hardware) : base(hardware){
            _selectedLED = _hardware.LEDs[0];
        }

        public override OperatorBase Create(){
            var oper = new LED();
//            oper.OnStateChanged += _selectedLED.SetValue;
            return oper;
        }

        public override string Name {
            get { return LED.OperatorName; }
        }

        public IBooleanValue[] LEDs {
            get { return _hardware.LEDs; }
        }

    }
}
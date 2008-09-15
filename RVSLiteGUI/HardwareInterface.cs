using RVSLite.Controls;
using RVSLite.HardwareDevices;

namespace RVSLite{
    public class HardwareInterface : IHardwareInterface{
        public HardwareInterface(){
            Bumpers = new HWTrigger[0];
            LEDs = new HWTrigger[0];
        }

        public IBooleanValue[] Bumpers { get; set; }
        public IBooleanValue[] LEDs { get; set; }


        public void SetLEDs(params LEDControl[] ledControls){
            LEDs = new HWTrigger[ledControls.Length];
            for (int i = 0; i < ledControls.Length; i++)
                LEDs[i] = new HWTrigger(ledControls[i]);
        }
    }
}
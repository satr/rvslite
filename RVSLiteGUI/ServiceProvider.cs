using System.Collections;
using RVSLite.Controls;
using RVSLite.HardwareDevices;

namespace RVSLite{
    public class ServiceProvider : IServiceProvider{
        public ServiceProvider(){
            BumperPorts = new BooleanValueService[0];
            LEDPorts = new BooleanValueService[0];
        }

        public IList BumperPorts { get; set; }
        public IList LEDPorts { get; set; }


        public void SetLEDs(params LEDControl[] ledControls){
            LEDPorts = new BooleanValueService[ledControls.Length];
            for (int i = 0; i < ledControls.Length; i++)
                LEDPorts[i] = new BooleanValueService(ledControls[i]);
        }
    }
}
using System.Collections;
using RVSLite.Controls;
using RVSLite.Services;

namespace RVSLite{
    public class ServiceProvider : IServiceProvider{
        public ServiceProvider(){
            DrivePorts = new BooleanValueService[0];
            BumperPorts = new BooleanValueService[0];
            LEDPorts = new BooleanValueService[0];
        }

        #region IServiceProvider Members

        public IList BumperPorts { get; set; }
        public IList LEDPorts { get; set; }
        public IList DrivePorts { get; set; }

        #endregion

        public void SetLEDs(params LEDControl[] controls){
            LEDPorts = new BooleanValueService[controls.Length];
            for (int i = 0; i < controls.Length; i++)
                LEDPorts[i] = new BooleanValueService(controls[i]);
        }

        public void SetBumpers(params BumperControl[] controls){
            BumperPorts = new BooleanValueService[controls.Length];
            for (int i = 0; i < controls.Length; i++)
                BumperPorts[i] = new BooleanValueService(controls[i]);
        }

        public void SetDrives(params DriveControl[] controls){
            DrivePorts = new BooleanValueService[controls.Length];
            for (int i = 0; i < controls.Length; i++)
                DrivePorts[i] = new BooleanValueService(controls[i]);
        }
    }
}
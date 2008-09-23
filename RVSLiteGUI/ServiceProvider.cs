using System.Collections.Generic;

namespace RVSLite{
    public class ServiceProvider : IServiceProvider{
        public ServiceProvider(){
            MessengerPorts = new List<IService>();
            DrivePorts = new List<IService>();
            BumperPorts = new List<IService>();
            LEDPorts = new List<IService>();
            Variables = new List<BaseActivity>();
        }

        #region IServiceProvider Members

        public List<IService> MessengerPorts { get; set; }
        public List<IService> BumperPorts { get; set; }
        public List<IService> DrivePorts { get; set; }
        public List<BaseActivity> Variables{get;set;}
        public List<IService> LEDPorts { get; set; }

        #endregion
    }
}
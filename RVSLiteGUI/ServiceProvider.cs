using System.Collections.Generic;

namespace RVSLite{
    public class ServiceProvider : IServiceProvider{
        public ServiceProvider(){
            DrivePorts = new List<IService>();
            BumperPorts = new List<IService>();
            LEDPorts = new List<IService>();
            ValueHolders = new List<BaseActivity>();
        }

        #region IServiceProvider Members

        public List<IService> BumperPorts { get; set; }
        public List<IService> DrivePorts { get; set; }
        public List<BaseActivity> ValueHolders{get;set;}
        public List<IService> LEDPorts { get; set; }

        #endregion
    }
}
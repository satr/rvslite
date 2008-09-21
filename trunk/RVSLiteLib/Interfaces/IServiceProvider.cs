using System.Collections;
using System.Collections.Generic;

namespace RVSLite{
    public interface IServiceProvider{
        List<IService> BumperPorts { get; set; }
        List<IService> LEDPorts { get; set; }
        List<IService> DrivePorts { get; set; }
        List<BaseActivity> ValueHolders { get; }
    }
}
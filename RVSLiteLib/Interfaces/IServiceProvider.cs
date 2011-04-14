using System.Collections;
using System.Collections.Generic;

namespace RVSLite{
    public interface IServiceProvider{
        List<IService> MessengerPorts { get; set; }
        List<IService> BumperPorts { get; set; }
        List<IService> LEDPorts { get; set; }
        List<IService> DrivePorts { get; set; }
        List<BaseActivity> Variables { get; }
        List<CompositeActivity> CompositeActivities { get; }
    }
}
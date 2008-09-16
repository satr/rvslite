using System.Collections;

namespace RVSLite{
    public interface IServiceProvider{
        IList BumperPorts { get; set; }
        IList LEDPorts { get; set; }
    }
}
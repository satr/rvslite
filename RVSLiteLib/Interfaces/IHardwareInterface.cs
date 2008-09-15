using System.Collections.Generic;

namespace RVSLite{
    public interface IHardwareInterface{
        IBooleanValue[] Bumpers { get; set; }
        IBooleanValue[] LEDs { get; set; }
    }
}
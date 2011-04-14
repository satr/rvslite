using System.Drawing;

namespace RVSLite{
    public interface IActivityControl2 : IActivityControl{
        bool OutputAvailableTo(NeighbourDirections direction);
    }

    public interface IActivityControl{
        BaseActivity Activity { get; set; }
        BaseActivity SourceActivity { get; set; }
        Color DefaultBGColor { get; set; }
        bool Selected { get; set; }
        void Init();
        event ActivityControlEventHandler OnClickActivityControl;
        void FireOnClickActivityControl();
    }
}
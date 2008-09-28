using System.Drawing;
using RVSLite.Controls.ActivityControls;

namespace RVSLite{
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
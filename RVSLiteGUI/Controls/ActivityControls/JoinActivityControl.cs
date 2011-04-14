using System.Drawing;
using System.Windows.Forms;
using RVSLite.Controls.ActivityControls;

namespace RVSLite.Controls{
    public partial class JoinActivityControl : UserControl, IActivityControl {
        public JoinActivityControl(){
            InitializeComponent();
            groupBox.Text = Lang.Res.Join;
        }

        public BaseActivity Activity { get; set; }

        private BaseActivity _sourceActivity = new NullActivity();
        public BaseActivity SourceActivity {
            get { return _sourceActivity; }
            set { _sourceActivity = value; }
        }

        public event ActivityControlEventHandler OnClickActivityControl;

        public Color DefaultBGColor { get; set; }

        public bool Selected { get; set; }

        public void Init() {
            ActivityControlsController.InitControlBy(this, groupBox);
            FireOnClickActivityControl();
        }

        public void FireOnClickActivityControl() {
            if (OnClickActivityControl != null)
                OnClickActivityControl(this);
        }
    }
}
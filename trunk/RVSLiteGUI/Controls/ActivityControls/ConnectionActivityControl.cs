using System.Drawing;
using System.Windows.Forms;

namespace RVSLite.Controls.ActivityControls{
    public partial class ConnectionActivityControl : UserControl, IActivityControl{
        private ConnectActivity _activity;

        public ConnectionActivityControl(){
            InitializeComponent();
            groupBox.Text = Lang.Res.Connection;
        }

        #region IActivityControl Members

        public BaseActivity Activity{
            get { return _activity; }
            set { _activity = (ConnectActivity) value; }
        }

        #endregion
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
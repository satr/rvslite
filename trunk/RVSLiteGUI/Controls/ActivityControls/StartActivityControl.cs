using System;
using System.Drawing;
using System.Windows.Forms;

namespace RVSLite.Controls.ActivityControls{
    public partial class StartActivityControl : UserControl, IActivityControl{
        public StartActivityControl(){
            InitializeComponent();
            btnStart.Text = groupBox.Text = Lang.Res.Start;
            btnStart.Click += btnStart_Click;
        }

        #region IActivityControl Members

        public BaseActivity Activity { get; set; }

        #endregion

        private void btnStart_Click(object sender, EventArgs e){
            if (Activity == null)
                return;
            Activity.Post(null);
        }
        private BaseActivity _sourceActivity = new NullActivity();
        public BaseActivity SourceActivity {
            get { return _sourceActivity; }
            set { _sourceActivity = value; }
        }


        public event ActivityControlEventHandler OnClickActivityControl;

        public Color DefaultBGColor { get; set; }

        public bool Selected { get; set; }

        public void Init() {
            MainController.InitControlBy(this, groupBox);
            FireOnClickActivityControl();
        }

        public void FireOnClickActivityControl() {
            if (OnClickActivityControl != null)
                OnClickActivityControl(this);
        }
    }
}
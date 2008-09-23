using System.Windows.Forms;

namespace RVSLite.Controls.ActivityControls{
    public partial class PauseActivityControl : UserControl, IActivityControl{
        private PauseActivity _activity;

        public PauseActivityControl(){
            InitializeComponent();
            groupBox.Text = Lang.Res.Pause;
        }

        #region IActivityControl Members

        public BaseActivity Activity{
            get { return _activity; }
            set { _activity = (PauseActivity) value; }
        }

        #endregion
    }
}
using System.Windows.Forms;

namespace RVSLite.Controls.ActivityControls{
    public partial class ConnectionActivityControl : UserControl, IActivityControl{
        private ConnectionActivity _activity;

        public ConnectionActivityControl(){
            InitializeComponent();
            groupBox.Text = Lang.Res.Connection;
        }

        #region IActivityControl Members

        public BaseActivity Activity{
            get { return _activity; }
            set { _activity = (ConnectionActivity) value; }
        }

        #endregion
    }
}
using System.Collections.Generic;
using System.Windows.Forms;

namespace RVSLite.Controls.ActivityControls{
    public partial class ServiceControl : UserControl, IActivityControl{
        private BaseActivity _activity;

        public ServiceControl(){
            InitializeComponent();
            lblPort.Text = Lang.Res.Port;
        }

        #region IActivityControl Members

        public BaseActivity Activity{
            get { return _activity; }
            set{
                _activity = (BaseActivity) value;
            }
        }

        #endregion

        public List<IService> Ports {
            set {
                cbInstances.DataSource = value;
            }
        }

        public string ControlName {
            set { groupBox.Text = value; }
        }

    }
}
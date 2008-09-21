using System.Collections.Generic;
using System.Windows.Forms;

namespace RVSLite.Controls.ActivityControls{
    public partial class LEDServiceControl : UserControl, IActivityControl{
        private LEDService _activity;

        public LEDServiceControl(){
            InitializeComponent();
            groupBox.Text = Lang.Res.LED;
            lblPort.Text = Lang.Res.Port;
        }

        #region IActivityControl Members

        public BaseActivity Activity{
            get { return _activity; }
            set{
                _activity = (LEDService) value;
            }
        }

        #endregion

        public List<IService> Ports {
            set {
                cbInstances.DataSource = value;
            }
        }
    }
}
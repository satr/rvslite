using System.Collections.Generic;
using System.Windows.Forms;

namespace RVSLite.Controls.ActivityControls{
    public partial class BumperServiceControl : UserControl, IActivityControl{
        private BumperService _activity;

        public BumperServiceControl(){
            InitializeComponent();
            groupBox.Text = Lang.Res.Bumper;
            lblPort.Text = Lang.Res.Port;
        }

        #region IActivityControl Members

        public BaseActivity Activity{
            get { return _activity; }
            set{
                _activity = (BumperService) value;
            }
        }

        #endregion

        public List<IService> Ports{
            set{
                cbInstances.DataSource = value;
            }
        }
    }
}
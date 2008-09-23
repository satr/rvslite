using System.Collections.Generic;
using System.Windows.Forms;

namespace RVSLite.Controls.ActivityControls{
    public partial class ServiceActivityControl : UserControl, IActivityControl{
        public ServiceActivityControl(){
            InitializeComponent();
            lblPort.Text = Lang.Res.Port;
            cbInstances.SelectedValueChanged += cbInstances_SelectedValueChanged;
        }

        void cbInstances_SelectedValueChanged(object sender, System.EventArgs e){
            RefreshPorts();
        }

        private void RefreshPorts(){
            if (_activity == null)
                return;
            _activity.Port = SelectedPort;
        }

        private IService SelectedPort{
            get { return (IService) cbInstances.SelectedValue; }
        }

        public List<IService> Ports{
            set{
                cbInstances.DataSource = value;
                RefreshPorts();
            }
        }

        public string ControlName{
            set { groupBox.Text = value; }
        }

        #region IActivityControl Members

        private ServiceActivity _activity;
        public BaseActivity Activity{
            get { return _activity; }
            set{
                _activity = (ServiceActivity) value;
                RefreshPorts();
            }
        }

        #endregion
    }
}
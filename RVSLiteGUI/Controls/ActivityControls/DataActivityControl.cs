using System.Windows.Forms;

namespace RVSLite.Controls.ActivityControls{
    public partial class DataActivityControl : UserControl, IActivityControl{
        private DataActivity _activity;

        public DataActivityControl(){
            InitializeComponent();
            groupBox.Text = Lang.Res.Data;
        }

        #region IActivityControl Members

        public BaseActivity Activity{
            get{
                _activity.Value = txtValue.Text;
                return _activity;
            }
            set{
                _activity = (DataActivity) value;
                lblInstanceName.Text = _activity.Name;
                txtValue.Text = _activity.Value == null ? "" : _activity.Value.ToString();
            }
        }

        #endregion
    }
}
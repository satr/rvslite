using System.Windows.Forms;

namespace RVSLite.Controls.ActivityControls{
    public partial class DataActivityControl : UserControl, IActivityControl{
        private DataActivity _activity;

        public DataActivityControl(){
            InitializeComponent();
            groupBox.Text = Lang.Res.Data;
            txtValue.TextChanged += txtValue_TextChanged;
        }

        void txtValue_TextChanged(object sender, System.EventArgs e) {
            if (_activity == null)
                return;
            _activity.Value = Settings.GetValueBy(txtValue.Text);
        }

        #region IActivityControl Members

        public BaseActivity Activity{
            get{
                return _activity;
            }
            set{
                _activity = (DataActivity) value;
                txtValue.Text = _activity.Value == null ? "" : _activity.Value.ToString();
            }
        }

        #endregion
    }
}
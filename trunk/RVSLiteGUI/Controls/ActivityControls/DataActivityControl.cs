using System;
using System.Drawing;
using System.Windows.Forms;

namespace RVSLite.Controls.ActivityControls{
    public partial class DataActivityControl : UserControl, IActivityControl{

        private DataActivity _activity;


        public DataActivityControl(){
            InitializeComponent();
            groupBox.Text = Lang.Res.Data;
            txtValue.TextChanged += txtValue_TextChanged;
            SourceActivity = new NullActivity();
        }

        #region IActivityControl Members

        public BaseActivity SourceActivity { get; set; }

        public event ActivityControlEventHandler OnClickActivityControl;

        public Color DefaultBGColor{get; set;}

        public bool Selected { get; set; }

        public void Init(){
            ActivityControlsController.InitControlBy(this, groupBox);
            FireOnClickActivityControl();
            txtValue.Focus();
        }

        public void FireOnClickActivityControl(){
            if (OnClickActivityControl != null)
                OnClickActivityControl(this);
        }


        public BaseActivity Activity{
            get { return _activity; }
            set{
                _activity = (DataActivity) value;
                txtValue.Text = _activity.Value == null ? "" : _activity.Value.ToString();
            }
        }

        #endregion

        private void txtValue_TextChanged(object sender, EventArgs e){
            if (_activity == null)
                return;
            _activity.Value = Settings.GetValueBy(txtValue.Text);
        }
    }
}
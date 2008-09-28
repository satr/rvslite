using System;
using System.Drawing;
using System.Windows.Forms;

namespace RVSLite.Controls.ActivityControls{
    public partial class PauseActivityControl : UserControl, IActivityControl{
        private CompositeActivityDecorator _activityDecorator = new CompositeActivityDecorator(new PauseActivity());
        readonly DataActivity _inputActivity = new DataActivity();

        public PauseActivityControl(){
            InitializeComponent();
            groupBox.Text = Lang.Res.Pause;
            txtValue.TextChanged += txtValue_TextChanged;
            txtValue.Text = "1000";
            txtValue.GotFocus += txtValue_GotFocus;
            cbUseConstant.CheckedChanged += cbUseConstant_CheckedChanged;
        }

        static void txtValue_GotFocus(object sender, EventArgs e) {
            MainController.WritePrompting(new[] { "Длительность паузы в миллисекундах.", Lang.Res.Comment_one_second_equal_to_1000_milliseconds });
        }

        void cbUseConstant_CheckedChanged(object sender, EventArgs e){
            txtValue.Enabled = UseInnerActivity;
            _activityDecorator.UseInnerActivity = UseInnerActivity;
        }

        private bool UseInnerActivity{
            get { return cbUseConstant.Checked; }
        }

        private void txtValue_TextChanged(object sender, EventArgs e) {
            if (_inputActivity == null)
                return;
            _inputActivity.Value = Settings.GetIntValueBy(txtValue.Text);
        }

        #region IActivityControl Members

        public BaseActivity Activity{
            get { return _activityDecorator; }
            set{
                _activityDecorator = (CompositeActivityDecorator) value;
                _activityDecorator.InputActivity = _inputActivity;
            }
        }

        #endregion
    
        private BaseActivity _sourceActivity = new NullActivity();
        public BaseActivity SourceActivity {
            get { return _sourceActivity; }
            set { _sourceActivity = value; }
        }
        public event ActivityControlEventHandler OnClickActivityControl;

        public Color DefaultBGColor { get; set; }

        public bool Selected { get; set; }

        public void Init() {
            txtValue.Focus();
            txtValue.SelectAll();
            MainController.InitControlBy(this, groupBox, pictureBox);
            FireOnClickActivityControl();
        }

        public void FireOnClickActivityControl() {
            if (OnClickActivityControl != null)
                OnClickActivityControl(this);
        }
    }
}
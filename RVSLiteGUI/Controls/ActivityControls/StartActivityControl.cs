using System;
using System.Windows.Forms;

namespace RVSLite.Controls.ActivityControls{
    public partial class StartActivityControl : UserControl, IActivityControl{
        public StartActivityControl(){
            InitializeComponent();
            btnStart.Text = groupBox.Text = Lang.Res.Start;
            btnStart.Click += btnStart_Click;
        }

        #region IActivityControl Members

        public BaseActivity Activity { get; set; }

        #endregion

        private void btnStart_Click(object sender, EventArgs e){
            if (Activity == null)
                return;
            Activity.Post(null);
        }
    }
}
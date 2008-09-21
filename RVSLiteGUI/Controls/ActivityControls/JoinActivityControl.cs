using System.Windows.Forms;

namespace RVSLite.Controls{
    public partial class JoinActivityControl : UserControl, IActivityControl {
        public JoinActivityControl(){
            InitializeComponent();
            groupBox.Text = Lang.Res.Join;
        }

        public BaseActivity Activity { get; set; }
    }
}
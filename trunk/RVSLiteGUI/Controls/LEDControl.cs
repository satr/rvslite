using System.Drawing;
using System.Windows.Forms;

namespace RVSLite.Controls{
    public partial class LEDControl : UserControl, IServiceControl {
        private bool _value;

        public LEDControl(){
            InitializeComponent();
        }

        #region IServiceControl Members

        public object Value{
            get { return _value; }
            set{
                _value = (bool)value;
                pictureBox.BackColor = _value ? Color.Yellow : Color.Gray;
            }
        }

        public string ServiceName{
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public event ValueEventHandler OnStateChanged;

        #endregion
    }
}
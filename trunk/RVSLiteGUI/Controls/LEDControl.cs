using System.Drawing;
using System.Windows.Forms;

namespace RVSLite.Controls{
    public partial class LEDControl : UserControl, IBooleanControl {
        private bool _value;

        public LEDControl(){
            InitializeComponent();
        }

        #region IBooleanControl Members

        public bool Value{
            get { return _value; }
            set{
                _value = value;
                pictureBox.BackColor = _value ? Color.Yellow : Color.Gray;
            }
        }

        public string HWName{
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public event PostEventHandler OnStateChanged;

        #endregion
    }
}
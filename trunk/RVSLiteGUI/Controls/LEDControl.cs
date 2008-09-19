using System.Drawing;
using System.Windows.Forms;

namespace RVSLite.Controls{
    public partial class LEDControl : UserControl, IService {
        private bool _value;

        public LEDControl(){
            InitializeComponent();
        }

        #region IService Members

        public object Value{
            get { return _value; }
            set{
                var valueChanged = _value = (bool)value;
                _value = (bool)value;
                pictureBox.BackColor = _value ? Color.Yellow : Color.Gray;
                if (valueChanged && OnStateChanged != null)
                    OnStateChanged(value);
            }
        }

        public string ServiceName{
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public void SetValue(object value){
            Value = value;
        }

        public event ValueEventHandler OnStateChanged;

        #endregion
    }
}
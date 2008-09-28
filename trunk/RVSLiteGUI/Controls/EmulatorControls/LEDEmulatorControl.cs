using System.Drawing;
using System.Windows.Forms;

namespace RVSLite.Controls{
    public partial class LEDEmulatorControl : UserControl, IService {
        private bool _value;

        public LEDEmulatorControl(){
            InitializeComponent();
        }

        #region IService Members

        public object Value{
            get { return _value; }
            set{
                bool inValue = Settings.GetBoolValueBy(value);
                if(_value == inValue)
                    return;
                _value = inValue;
                pictureBox.BackColor = _value ? Color.Yellow : Color.Gray;
                if (OnStateChanged != null)
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
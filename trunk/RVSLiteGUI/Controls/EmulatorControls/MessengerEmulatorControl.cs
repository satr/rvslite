using System.Windows.Forms;

namespace RVSLite.Controls.EmulatorControls{
    public partial class MessengerEmulatorControl : UserControl, IService{
        private string _value;

        public MessengerEmulatorControl(){
            InitializeComponent();
        }

        #region IService Members

        public object Value{
            get { return _value; }
            set{
                var checkedValue = (value == null? string.Empty: value.ToString());
                bool valueChanged = (_value != checkedValue);
                _value = checkedValue;
                textBox1.Text = _value;
                if (valueChanged && OnStateChanged != null)
                    OnStateChanged(value);
            }
        }

        public string ServiceName{
            get { return groupBox.Text; }
            set { groupBox.Text = value; }
        }

        public void SetValue(object value){
            Value = value;
        }

        public event ValueEventHandler OnStateChanged;

        #endregion
    }
}
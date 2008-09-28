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
                if (_value == checkedValue)
                    return;
                _value = checkedValue;
                SetText(_value.ToString());
                if (OnStateChanged != null)
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

        private void SetText(string text) {
            if (textBox1.InvokeRequired) {
                var d = new SetTextCallback(SetText);
                Invoke(d, new object[] { text });
            }
            else {
                textBox1.AppendText(text);
            }
        }

        private delegate void SetTextCallback(string text);
    }
}
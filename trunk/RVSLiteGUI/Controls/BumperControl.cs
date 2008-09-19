using System;
using System.Drawing;
using System.Windows.Forms;

namespace RVSLite.Controls{
    public partial class BumperControl : UserControl, IService{
        private bool _value;

        public BumperControl(){
            InitializeComponent();
            Value = false;
            pictureBox.Click += pictureBox_Click;
        }

        #region IService Members

        public void SetValue(object value){
            Value = value;
        }

        public event ValueEventHandler OnStateChanged;

        public object Value{
            get { return _value; }
            set{
                if (_value == (bool) value)
                    return;
                _value = (bool) value;
                pictureBox.BackColor = _value ? Color.DarkViolet : Color.Gray;
                if (OnStateChanged != null)
                    OnStateChanged(_value);
            }
        }

        public string ServiceName{
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        #endregion

        private void pictureBox_Click(object sender, EventArgs e){
            Value = !(bool)Value;
        }
    }
}
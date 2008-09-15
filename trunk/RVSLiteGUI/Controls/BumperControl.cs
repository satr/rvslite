using System;
using System.Drawing;
using System.Windows.Forms;

namespace RVSLite.Controls{
    public partial class BumperControl : UserControl, ITriggerControl{
        private bool _value;

        public BumperControl(){
            InitializeComponent();
            Value = false;
            pictureBox.Click += pictureBox_Click;
        }

        #region ITriggerControl Members

        public event BooleanEventHandler OnStateChanged;

        public bool Value{
            get { return _value; }
            set{
                if (_value == value)
                    return;
                _value = value;
                pictureBox.BackColor = _value ? Color.DarkViolet : Color.Gray;
                if (OnStateChanged != null)
                    OnStateChanged(_value);
            }
        }

        public string HWName{
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        #endregion

        private void pictureBox_Click(object sender, EventArgs e){
            Value = !Value;
        }
    }
}
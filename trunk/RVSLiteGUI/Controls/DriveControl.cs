using System.Windows.Forms;

namespace RVSLite.Controls{
    public partial class DriveControl : UserControl, IService{
        private int _value;

        public DriveControl(){
            InitializeComponent();
        }

        #region IService Members

        public void SetValue(object value){
            Value = value;
        }

        public event ValueEventHandler OnStateChanged;

        public object Value{
            get { return _value; }
            set{
                bool valueChanged = _value != (int) value;
                _value = (int) value;
                if (_value > 0)
                    pictureBox.Image = imageList.Images[0];
                else if (_value == 0)
                    pictureBox.Image = imageList.Images[1];
                else 
                    pictureBox.Image = imageList.Images[2];
                if (valueChanged && OnStateChanged != null)
                    OnStateChanged(_value);
            }
        }

        public string ServiceName{
            get { return "Drive"; }
            set { }
        }

        #endregion
    }
}
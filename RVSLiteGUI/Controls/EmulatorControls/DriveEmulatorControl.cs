using System.Windows.Forms;

namespace RVSLite.Controls{
    public partial class DriveEmulatorControl : UserControl, IService{
        private int _value;
        private string _name = Lang.Res.Drive;

        public DriveEmulatorControl(){
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
                var checkedValue = value is int ? (int) value : 0;
                bool valueChanged = _value != checkedValue;
                _value = checkedValue;
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
            get { return _name; }
            set { _name = value; }
        }

        #endregion
    }
}
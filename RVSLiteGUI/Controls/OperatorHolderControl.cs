using System;
using System.Windows.Forms;

namespace RVSLite.Controls{
    public partial class OperatorHolderControl : UserControl{
        public OperatorHolderControl(){
            InitializeComponent();
            RefireEvent(Controls);
        }

        private OperatorBase _operator;
        public OperatorBase Operator{
            get { return _operator; }
            set{
                _operator = value;
                lblName.Text = _operator.Name;
            }
        }

        public event EventHandler OnHolderClick;

        private void RefireEvent(ControlCollection controls){
            foreach (Control control in controls){
                control.Click += control_Click;
                RefireEvent(control.Controls);
            }
        }

        private void control_Click(object sender, EventArgs e){
            if (OnHolderClick != null)
                OnHolderClick(this, e);
        }
    }
}
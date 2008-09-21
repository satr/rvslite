using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RVSLite.Controls{
    public partial class OperatorHolderControl : UserControl{
        readonly Dictionary<NeighbourDirections, OperatorHolderControl> _neihgbours = new Dictionary<NeighbourDirections, OperatorHolderControl>();
        public OperatorHolderControl(){
            InitializeComponent();
            RefireEvent(Controls);
        }

        private BaseActivity _activity;
        public BaseActivity Activity{
            get { return _activity; }
            set{
                elementPropertiesControl.Value = _activity = value;
                if(_activity.IsOperatorWithOperation){
                    var oper = ((ActivityWithOperation) _activity);
                    lblOperation.Visible = elementPropertiesControl2.Visible = true;
                    lblOperation.Text = oper.OperationCommand.ToString();
                    elementPropertiesControl2.Value = oper.Variable;
                }
            }
        }

        public Dictionary<NeighbourDirections, OperatorHolderControl> Neihgbours{
            get { return _neihgbours; }
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

        public OperatorHolderControl NearestNeighbourOperator{
            get{
                foreach (var direction in GetNeighbourDirections()){
                    var neihgbour = Neihgbours[direction];
                    if (neihgbour != null
                        && neihgbour.Activity != null)
                        return neihgbour;
                }
                return null;
            }
        }

        public static NeighbourDirections[] GetNeighbourDirections(){
            return new[]{NeighbourDirections.Left, NeighbourDirections.Top, NeighbourDirections.Bottom, NeighbourDirections.Right};
        }
    }
}
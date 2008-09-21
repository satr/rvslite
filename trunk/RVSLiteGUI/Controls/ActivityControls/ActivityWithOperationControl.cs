using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RVSLite.Controls.ActivityControls{
    public partial class ActivityWithOperationControl : UserControl, IActivityControl{
        private ActivityWithOperation _activity;

        public ActivityWithOperationControl(){
            InitializeComponent();
            Resize += IfClauseActivityControl_Resize;
            cbInstances.SelectedIndexChanged += cbInstances_SelectedIndexChanged;
        }

        public string ControlName{
            set {
                groupBox.Text = value;
            }
        }

        public List<BaseActivity> Variables{
            set{
                var variables = new List<BaseActivity>(value);
                variables.Insert(0, new DataActivity());
                cbInstances.DataSource = variables;
                ResizeValueField();
            }
        }

        #region IActivityControl Members

        public BaseActivity Activity{
            get { return _activity; }
            set{
                _activity = (ActivityWithOperation)value;
                lblSource.Text = _activity.SourceActivity.Name;
                lblOperator.Text = _activity.OperationCommand.ToString();
            }
        }

        #endregion

        private void IfClauseActivityControl_Resize(object sender, EventArgs e){
            ResizeValueField();
        }

        private void cbInstances_SelectedIndexChanged(object sender, EventArgs e){
            txtValue.Visible = !((VariableActivity) cbInstances.SelectedValue).IsVariable;
        }

        private void ResizeValueField(){
            txtValue.Location = new Point(cbInstances.Location.X, cbInstances.Location.Y);
            txtValue.Size = new Size(Size.Width - 20, Size.Height);
        }
    }
}
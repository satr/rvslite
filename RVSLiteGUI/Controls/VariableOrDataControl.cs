using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RVSLite.Controls{
    public partial class VariableOrDataControl : UserControl{
        public VariableOrDataControl(){
            InitializeComponent();
            Resize += ActivityWithOperationControl_Resize;
            cbInstances.SelectedIndexChanged += cbInstances_SelectedIndexChanged;
        }

        public List<BaseActivity> Variables{
            set{
                var variables = new List<BaseActivity>(value);
                variables.Insert(0, new DataActivity());
                cbInstances.DataSource = variables;
                ResizeValueField();
            }
        }

        private void ActivityWithOperationControl_Resize(object sender, EventArgs e){
            ResizeValueField();
        }

        private void cbInstances_SelectedIndexChanged(object sender, EventArgs e){
            txtValue.Visible = !((VariableActivity) cbInstances.SelectedValue).IsVariable;
        }

        private void ResizeValueField(){
            txtValue.Location = new Point(cbInstances.Location.X, cbInstances.Location.Y);
            txtValue.Size = new Size(Size.Width - 20, Size.Height);
        }

        public VariableActivity SelectedActivity{
            get {
                return (VariableActivity) cbInstances.SelectedValue;
            }
        }
    }
}
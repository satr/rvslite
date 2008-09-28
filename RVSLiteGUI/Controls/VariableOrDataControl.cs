using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RVSLite.Controls{
    public partial class VariableOrDataControl : UserControl{
        public event EventHandler OnChanged;
        private readonly DataActivity _dataActivity = new DataActivity();
        private int _lastVariablesCount = -1;

        public VariableOrDataControl(){
            InitializeComponent();
            Resize += ActivityWithOperationControl_Resize;
            cbInstances.SelectedIndexChanged += cbInstances_SelectedIndexChanged;
            cbInstances.DropDown += cbInstances_DropDown;
            SelectedActivity = _dataActivity;
            txtValue.TextChanged += txtValue_TextChanged;
        }

        void cbInstances_DropDown(object sender, EventArgs e){
            var variables = ServiceProvider.Variables;
            if (variables.Count == _lastVariablesCount)
                return;
            InitVariables(variables);
            _lastVariablesCount = variables.Count;
        }

        public void InitVariables(List<BaseActivity> sourceVariablesList){
                var variables = new List<BaseActivity>(sourceVariablesList);
                variables.Insert(0, _dataActivity);
                cbInstances.DataSource = variables;
                SelectLastActivity(SelectedActivity);
                ResizeValueField();
        }

        private void SelectLastActivity(VariableActivity lastSelectedActivity){
            for (int i = 0; i < cbInstances.Items.Count; i++){
                if (cbInstances.Items[i] == lastSelectedActivity){
                    cbInstances.SelectedIndex = i;
                    break;
                }
            }
        }

        private void ActivityWithOperationControl_Resize(object sender, EventArgs e){
            ResizeValueField();
        }

        private void cbInstances_SelectedIndexChanged(object sender, EventArgs e){
            SelectedActivity = (VariableActivity)cbInstances.SelectedValue;
            txtValue.Visible = !SelectedActivity.IsVariable;
            if(OnChanged != null)
                OnChanged(this, EventArgs.Empty);
        }

        private void ResizeValueField(){
            txtValue.Location = new Point(cbInstances.Location.X, cbInstances.Location.Y);
            txtValue.Size = new Size(Size.Width - 20, Size.Height);
        }

        public VariableActivity SelectedActivity { get; private set; }

        public IServiceProvider ServiceProvider { get; set; }

        private void txtValue_TextChanged(object sender, EventArgs e) {
            if (SelectedActivity == null)
                return;
            SelectedActivity.Value = Settings.GetValueBy(txtValue.Text);
        }
    }
}
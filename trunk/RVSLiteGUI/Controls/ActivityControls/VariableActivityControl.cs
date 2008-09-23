using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RVSLite.Controls.ActivityControls{
    public partial class VariableActivityControl : UserControl, IActivityControl{
        private VariableActivity _activity;
        private VariableActivityCreator _variableActivityCreator;

        public VariableActivityControl(){
            InitializeComponent();
            groupBox.Text = Lang.Res.Variable;
            btnNew.Click += btnNew_Click;
        }

        public VariableActivityCreator VariableActivityCreator{
            set{
                _variableActivityCreator = value;
                var variables = _variableActivityCreator.ServiceProvider.Variables;
                if(variables.Count == 0)
                    variables.Add(_variableActivityCreator.Create());
                InitInstancesListBy(variables);
            }
        }

        #region IActivityControl Members

        public BaseActivity Activity{
            get { return (BaseActivity) cbInstances.SelectedValue; }
            set { }
        }

        #endregion

        private void btnNew_Click(object sender, EventArgs e){
            var addVariableForm = new AddVariableForm(_variableActivityCreator);
            if (addVariableForm.ShowDialog() == DialogResult.Cancel)
                return;
            InitInstancesListBy(_variableActivityCreator.ServiceProvider.Variables);
            SelectInstance(addVariableForm.NewActivity);
        }

        private void SelectInstance(BaseActivity activity){
            var items = cbInstances.Items;
            for (int i = 0; i < items.Count; i++){
                if (items[i] != activity)
                    continue;
                cbInstances.SelectedIndex = i;
                break;
            }
        }

        private void InitInstancesListBy(IEnumerable<BaseActivity> variables){
            cbInstances.DataSource = new List<BaseActivity>(variables);
        }
    }
}
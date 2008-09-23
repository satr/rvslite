using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RVSLite.Controls.ActivityControls{
    public partial class ActivityWithOperationControl : UserControl, IActivityControl{
        private ActivityWithOperation _activity;

        public ActivityWithOperationControl(){
            InitializeComponent();
            cbOperationCommands.SelectedValueChanged += cbOperationCommands_SelectedValueChanged;
            variableOrDataControl.OnChanged += variableOrDataControl_OnChanged;
        }

        void variableOrDataControl_OnChanged(object sender, EventArgs e) {
            RefreshActivity();
        }

        public string ControlName{
            set { groupBox.Text = value; }
        }

        public IServiceProvider ServiceProvider{
            set { variableOrDataControl.ServiceProvider = value; }
        }

        public IEnumerable<OperationsCommandBase> OperationCommands{
            set { cbOperationCommands.DataSource = new List<OperationsCommandBase>(value); }
        }

        #region IActivityControl Members

        public BaseActivity Activity{
            get { return _activity; }
            set{
                _activity = (ActivityWithOperation) value;
                lblSource.Text = _activity.SourceActivity.Name;
            }
        }

        #endregion

        private void cbOperationCommands_SelectedValueChanged(object sender, EventArgs e){
            RefreshActivity();
        }

        private void RefreshActivity(){
            if (_activity == null)
                return;
            _activity.InitBy(SelectedOperationCommand, SelectedActivity);
        }

        private VariableActivity SelectedActivity{
            get { return variableOrDataControl.SelectedActivity; }
        }

        private OperationsCommandBase SelectedOperationCommand{
            get { return (OperationsCommandBase) cbOperationCommands.SelectedValue; }
        }
    }
}
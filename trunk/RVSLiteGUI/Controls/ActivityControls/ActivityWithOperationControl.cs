using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RVSLite.Controls.ActivityControls{
    public partial class ActivityWithOperationControl : UserControl, IActivityControl{
        private ActivityWithOperation _activity;
        private readonly VariableActivityHolder _sourceActivity = new VariableActivityHolder();

        public ActivityWithOperationControl(){
            InitializeComponent();
            cbOperationCommands.SelectedValueChanged += cbOperationCommands_SelectedValueChanged;
            variableOrDataControl.OnChanged += variableOrDataControl_OnChanged;
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

        private VariableActivity SelectedActivity{
            get { return variableOrDataControl.SelectedActivity; }
        }

        private OperationsCommandBase SelectedOperationCommand{
            get { return (OperationsCommandBase) cbOperationCommands.SelectedValue; }
        }

        #region IActivityControl Members

        public BaseActivity Activity{
            get { return _activity; }
            set{
                _activity = (ActivityWithOperation) value;
                RefreshSourceActivityProperty(SourceActivity);
                RefreshActivity();
            }
        }

        public BaseActivity SourceActivity{
            get { return _sourceActivity; }
            set{
                if (_sourceActivity.InnerVariableActivity == value || !value.IsVariable)
                    return;
                if (_sourceActivity.InnerVariableActivity != null)
                    ((VariableActivity) _sourceActivity.InnerVariableActivity).OnChanged -= _sourceActivity_OnChanged;
                _sourceActivity.InnerVariableActivity = ((VariableActivityHolder) value).InnerVariableActivity;
                if (_sourceActivity.InnerVariableActivity != null)
                    ((VariableActivity)_sourceActivity.InnerVariableActivity).OnChanged += _sourceActivity_OnChanged;
            }
        }

        #endregion

        private void variableOrDataControl_OnChanged(object sender, EventArgs e){
            RefreshActivity();
        }

        private static void RefreshSourceActivityProperty(BaseActivity sourceActivity){
//            lblSource.Text = (sourceActivity == null) ? Lang.Res.Undefined : sourceActivity.Name;
        }

        private static void _sourceActivity_OnChanged(VariableActivity variableActivity){
            RefreshSourceActivityProperty(variableActivity);
        }

        private void cbOperationCommands_SelectedValueChanged(object sender, EventArgs e){
            RefreshActivity();
        }

        private void RefreshActivity(){
            if (_activity == null)
                return;
            _activity.InitBy(SelectedOperationCommand, SelectedActivity);
        }
        public event ActivityControlEventHandler OnClickActivityControl;

        public Color DefaultBGColor { get; set; }

        public bool Selected { get; set; }

        public void Init() {
            ActivityControlsController.InitControlBy(this, groupBox);
            FireOnClickActivityControl();
        }

        public void FireOnClickActivityControl() {
            if (OnClickActivityControl != null)
                OnClickActivityControl(this);
        }
    }
}
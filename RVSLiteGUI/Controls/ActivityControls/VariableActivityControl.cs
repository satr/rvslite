using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RVSLite.Controls.ActivityControls{
    public partial class VariableActivityControl : UserControl, IActivityControl{
        private readonly VariableActivityHolder _variableActivityHolder = new VariableActivityHolder();
        private VariableActivityFactory _variableActivityFactory;

        public VariableActivityControl(){
            InitializeComponent();
            groupBox.Text = Lang.Res.Variable;
            btnNew.Text = Lang.Res.New_p;
            btnNew.Click += btnNew_Click;
            Activity = new VariableActivity(Lang.Res.Undefined);
            cbInstances.Enabled = false;
            cbInstances.SelectedIndexChanged += cbInstances_SelectedIndexChanged;
        }

        void cbInstances_SelectedIndexChanged(object sender, EventArgs e){
            var selectedActivity = (BaseActivity) cbInstances.SelectedValue;
            if(Activity == selectedActivity)
                return;
            if (SourceActivity != null && Activity != null)
                SourceActivity.OnPost -= Activity.Post;
            Activity = selectedActivity;
            if (SourceActivity != null && Activity != null)
                SourceActivity.OnPost += Activity.Post;
        }

        public VariableActivityFactory VariableActivityFactory{
            set{
                _variableActivityFactory = value;
                InitInstancesListBy(_variableActivityFactory.ServiceProvider.Variables);
            }
        }

        #region IActivityControl Members

        public BaseActivity Activity{
            get { return _variableActivityHolder; }
            set { _variableActivityHolder.InnerVariableActivity = value; }
        }

        #endregion

        private void btnNew_Click(object sender, EventArgs e){
            AddVariable();
        }

        private bool AddVariable(){
            var addVariableForm = new AddVariableForm(_variableActivityFactory);
            if (addVariableForm.ShowDialog() == DialogResult.Cancel)
                return false;
            InitInstancesListBy(_variableActivityFactory.ServiceProvider.Variables);
            SelectInstance(addVariableForm.NewActivity);
            return true;
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

        private void InitInstancesListBy(ICollection<BaseActivity> variables){
            cbInstances.Enabled = variables.Count > 0;
            cbInstances.DataSource = new List<BaseActivity>(variables);
        }
        private BaseActivity _sourceActivity = new NullActivity();
        public BaseActivity SourceActivity {
            get { return _sourceActivity; }
            set { _sourceActivity = value; }
        }

        public event ActivityControlEventHandler OnClickActivityControl;

        public Color DefaultBGColor { get; set; }

        public bool Selected { get; set; }

        public void Init() {
            ActivityControlsController.InitControlBy(this, groupBox, pnlNew);
            FireOnClickActivityControl();
            if (cbInstances.Items.Count > 0)
                return;
            if (AddVariable())
                return;
        }

        public void FireOnClickActivityControl() {
            if (OnClickActivityControl != null)
                OnClickActivityControl(this);
        }
    }
}
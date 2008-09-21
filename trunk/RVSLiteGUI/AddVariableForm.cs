using System.ComponentModel;
using System.Windows.Forms;

namespace RVSLite{
    public partial class AddVariableForm : Form{
        private readonly VariableActivityCreator _variableActivityCreator;

        public AddVariableForm(VariableActivityCreator variableActivityCreator){
            _variableActivityCreator = variableActivityCreator;
            InitializeComponent();
            Text = Lang.Res.New_variable;
            lblName.Text = Lang.Res.Name;
            btnCancel.Text = Lang.Res.Cancel;
            lblError.Text = string.Format("{0}: {1}", Lang.Res.Error, Lang.Res.Name_is_already_in_use);
            Closing += AddVariableForm_Closing;
        }

        private void AddVariableForm_Closing(object sender, CancelEventArgs e){
            if (DialogResult == DialogResult.Cancel)
                return;
            txtName.Text = txtName.Text.Trim();
            string name = txtName.Text;
            if (!CheckNameIsValid(name)){
                e.Cancel = true;
                return;
            }
            NewActivity = _variableActivityCreator.Create();
            NewActivity.Name = name;
            _variableActivityCreator.ServiceProvider.Variables.Add(NewActivity);
        }

        public BaseActivity NewActivity { get; set; }

        private bool CheckNameIsValid(string name){
            if (name.Length == 0){
                SetError(Lang.Res.Require_correct_name);
                return false;
            }
            foreach (VariableActivity variable in _variableActivityCreator.ServiceProvider.Variables) {
                if (variable.Name == name){
                    SetError(Lang.Res.Name_is_already_in_use);
                    return false;
                }
            }
            lblError.Visible = false;
            return true;
        }

        private void SetError(string errorMessage){
            lblError.Text = errorMessage;
            lblError.Visible = true;
        }
    }
}
using System.ComponentModel;
using System.Windows.Forms;

namespace RVSLite{
    public partial class AddVariableForm : Form{
        private readonly VariableActivityFactory _variableActivityFactory;

        public AddVariableForm(VariableActivityFactory variableActivityFactory){
            _variableActivityFactory = variableActivityFactory;
            InitializeComponent();
            Text = Lang.Res.New_variable;
            lblName.Text = Lang.Res.Name;
            lblError.Text = string.Format("{0}: {1}", Lang.Res.Error, Lang.Res.Name_is_already_in_use);
            lblValue.Text = Lang.Res.Value;
            lblValueError.Text = string.Format("{0}: {1}", Lang.Res.Error, Lang.Res.Name_is_already_in_use);
            btnCancel.Text = Lang.Res.Cancel;
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
            txtValue.Text = txtValue.Text.Trim();
            string value = txtValue.Text;
            if (!CheckValueIsValid(value)){
                e.Cancel = true;
                return;
            }
            NewActivity = new VariableActivity();
            NewActivity.Name = name;
            NewActivity.Value = Settings.GetValueBy(value);
            _variableActivityFactory.ServiceProvider.Variables.Add(NewActivity);
        }

        private bool CheckValueIsValid(string value) {
            if (value.Length == 0) {
                SetError(Lang.Res.Value_is_not_defined, lblValueError);
                return false;
            }
            lblError.Visible = false;
            return true;
        }

        public VariableActivity NewActivity { get; set; }

        private bool CheckNameIsValid(string name){
            if (name.Length == 0){
                SetError(Lang.Res.Require_correct_name, lblError);
                return false;
            }
            foreach (VariableActivity variable in _variableActivityFactory.ServiceProvider.Variables) {
                if (variable.Name == name){
                    SetError(Lang.Res.Name_is_already_in_use, lblError);
                    return false;
                }
            }
            lblError.Visible = false;
            return true;
        }

        private static void SetError(string errorMessage, Label errorLabel){
            errorLabel.Text = errorMessage;
            errorLabel.Visible = true;
        }
    }
}
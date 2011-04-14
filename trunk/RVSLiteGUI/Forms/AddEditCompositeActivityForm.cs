using System.ComponentModel;
using System.Windows.Forms;

namespace RVSLite {
    public partial class AddEditCompositeActivityForm : Form {
        private readonly CompositeActivityFactory _compositeActivityFactory;

        public AddEditCompositeActivityForm(CompositeActivityFactory compositeActivityFactory) {
            _compositeActivityFactory = compositeActivityFactory;
            InitializeComponent();
            Text = Lang.Res.Activity;
            lblName.Text = Lang.Res.Name;
            lblError.Text = string.Format("{0}: {1}", Lang.Res.Error, Lang.Res.Name_is_already_in_use);
            btnCancel.Text = Lang.Res.Cancel;
            Closing += Form_Closing;
        }

        public CompositeActivity NewActivity { get; set; }

        private void Form_Closing(object sender, CancelEventArgs e) {
            if (DialogResult == DialogResult.Cancel)
                return;
            txtName.Text = txtName.Text.Trim();
            string name = txtName.Text;
            if (!CheckNameIsValid(name)) {
                e.Cancel = true;
                return;
            }
            NewActivity = new CompositeActivity();
            NewActivity.Name = name;
            _compositeActivityFactory.ServiceProvider.Variables.Add(NewActivity);
        }

        private bool CheckNameIsValid(string name) {
            if (name.Length == 0) {
                SetError(Lang.Res.Require_correct_name, lblError);
                return false;
            }
            foreach (VariableActivity variable in _compositeActivityFactory.ServiceProvider.Variables) {
                if (variable.Name == name) {
                    SetError(Lang.Res.Name_is_already_in_use, lblError);
                    return false;
                }
            }
            lblError.Visible = false;
            return true;
        }

        private static void SetError(string errorMessage, Control errorLabel) {
            errorLabel.Text = errorMessage;
            errorLabel.Visible = true;
        }
    }
}
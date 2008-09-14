using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace RVSLite{
    public partial class OperationsListForm : Form{
        private OperatorBase _selectedOperator = new NullOperator();

        public OperationsListForm(MainController mainController){
            InitializeComponent();
            InitControls(mainController);
            Bind();
        }

        private void Bind(){
            btnAdd.Click += new System.EventHandler(btnAdd_Click);
            Closing +=OperationsListForm_Closing;
        }

        private void btnAdd_Click(object sender, EventArgs e){
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OperationsListForm_Closing(object sender, CancelEventArgs e){
            if (DialogResult == DialogResult.Cancel)
                return;
            var operatorCreator  = (OperatorCreatorBase) cbOperations.SelectedValue;
            _selectedOperator = operatorCreator.Create();
        }

        public OperatorBase SelectedOperator{
            get { return _selectedOperator; }
        }

        private void InitControls(MainController mainController){
            cbOperations.DisplayMember = "Name";
            cbOperations.DataSource = mainController.OperatorCreatorsList;
        }
    }
}
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace RVSLite {
    public partial class OperationsListForm : Form {
        private OperatorBase _selectedOperator = new NullOperator();
        private readonly ServiceCoordinator _serviceCoordinator;

        public OperationsListForm(MainController mainController) {
            InitializeComponent();
            InitControls(mainController);
            _serviceCoordinator = mainController.ServiceCoordinator;
            Bind();
        }

        public OperatorBase SelectedOperator {
            get { return _selectedOperator; }
        }

        private void Bind() {
            btnAdd.Click += btnAdd_Click;
            Closing += OperationsListForm_Closing;
            Activated += OperationsListForm_Activated;
            cbOperations.SelectedValueChanged += cbOperations_SelectedValueChanged;
        }

        private void cbOperations_SelectedValueChanged(object sender, EventArgs e) {
            RefreshSelection();
        }

        private void OperationsListForm_Activated(object sender, EventArgs e) {
            RefreshSelection();
        }

        private void RefreshSelection() {
            propertyGrid.SelectedObject = cbOperations.SelectedValue;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OperationsListForm_Closing(object sender, CancelEventArgs e) {
            if (DialogResult == DialogResult.Cancel)
                return;
            var operatorCreator = (OperatorCreatorBase) cbOperations.SelectedValue;
            _selectedOperator = operatorCreator.Create();
        }

        private void InitControls(MainController mainController) {
            cbOperations.DisplayMember = "Name";
            cbOperations.DataSource = mainController.OperatorCreatorsList;
        }
    }
}
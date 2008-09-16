using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace RVSLite{
    public partial class OperatorsListForm : Form{
        private readonly ServiceCoordinator _serviceCoordinator;
        private ElementCreatorBase _selectedElementCreator;
        private OperatorBase _selectedOperator = new NullOperator();

        public OperatorsListForm(MainController mainController){
            InitializeComponent();
            InitControls(mainController);
            _serviceCoordinator = mainController.ServiceCoordinator;
            cbInstances.SelectedIndexChanged += cbInstances_SelectedIndexChanged;
            Bind();
        }

        public OperatorBase SelectedOperator{
            get { return _selectedOperator; }
        }

        private ElementCreatorBase SelectedElementCreator{
            get { return _selectedElementCreator; }
            set{
                _selectedElementCreator = value;
                cbInstances.DataSource = _selectedElementCreator.Instances;
                RefreshSelectedInstanceProperties();
            }
        }

        private void cbInstances_SelectedIndexChanged(object sender, EventArgs e){
            RefreshSelectedInstanceProperties();
        }

        private void RefreshSelectedInstanceProperties(){
            _selectedOperator = (OperatorBase) cbInstances.SelectedValue;
            txtName.Text = _selectedOperator == null? "Null": _selectedOperator.Name;
        }

        private void Bind(){
            btnAdd.Click += btnAdd_Click;
            Closing += OperationsListForm_Closing;
            Activated += OperationsListForm_Activated;
            cbElementCreators.SelectedValueChanged += cbOperations_SelectedValueChanged;
        }

        private void cbOperations_SelectedValueChanged(object sender, EventArgs e){
            RefreshSelection();
        }

        private void OperationsListForm_Activated(object sender, EventArgs e){
            RefreshSelection();
        }

        private void RefreshSelection(){
            SelectedElementCreator = (ElementCreatorBase) cbElementCreators.SelectedValue;
        }


        private void btnAdd_Click(object sender, EventArgs e){
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OperationsListForm_Closing(object sender, CancelEventArgs e){
            if (DialogResult == DialogResult.Cancel)
                return;
        }

        private void InitControls(MainController mainController){
            cbElementCreators.DisplayMember = "Name";
            cbElementCreators.DataSource = mainController.OperatorCreatorsList;
        }
    }
}
using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using RVSLite.Controls;

namespace RVSLite{
    public partial class OperatorsListForm : Form{
        private readonly OperatorsController _operatorsController;
        private ElementCreatorBase _selectedElementCreator;
        private BaseOperator _selectedOperator = new BaseOperator();
        private OperatorHolderControl _sourceOperatorHolderControl;

        public OperatorsListForm(MainController mainController){
            InitializeComponent();
            InitControls(mainController);
            _operatorsController = mainController.OperatorsController;
            cbInstances.SelectedIndexChanged += cbInstances_SelectedIndexChanged;
            Bind();
        }

        public BaseOperator SelectedOperator{
            get { return _selectedOperator; }
        }

        private ElementCreatorBase SelectedElementCreator{
            get { return _selectedElementCreator; }
            set{
                _selectedElementCreator = value;
                cbInstances.DataSource = _selectedElementCreator.GetInstancesBy(_sourceOperatorHolderControl);
                RefreshSelectedInstanceProperties();
            }
        }

        private void cbInstances_SelectedIndexChanged(object sender, EventArgs e){
            RefreshSelectedInstanceProperties();
        }

        private void RefreshSelectedInstanceProperties(){
            _selectedOperator = (BaseOperator) cbInstances.SelectedValue;
            txtName.Text = _selectedOperator == null? "Null": _selectedOperator.Name;
        }

        private void Bind(){
            btnAdd.Click += btnAdd_Click;
            Closing += OperationsListForm_Closing;
            cbElementCreators.SelectedValueChanged += cbOperations_SelectedValueChanged;
        }

        private void cbOperations_SelectedValueChanged(object sender, EventArgs e){
            RefreshSelection();
        }

        private void RefreshSelection(){
            SelectedElementCreator = (ElementCreatorBase) cbElementCreators.SelectedValue;
            txtAloneElementName.Text = SelectedElementCreator.Name;
            var elementIsAlone = cbInstances.Items.Count == 1;
            txtName.ReadOnly = txtAloneElementName.Visible = elementIsAlone;
            cbInstances.Visible = !elementIsAlone;
        }


        private void btnAdd_Click(object sender, EventArgs e){
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OperationsListForm_Closing(object sender, CancelEventArgs e){
            if (DialogResult == DialogResult.Cancel)
                return;
            _selectedOperator.Name = txtName.Text;
        }

        private void InitControls(MainController mainController){
            cbElementCreators.DisplayMember = "Name";
            cbElementCreators.DataSource = mainController.OperatorCreatorsList;
        }

        public DialogResult ActivateFor(OperatorHolderControl operatorHolderControl){
            _sourceOperatorHolderControl = operatorHolderControl.NearestNeighbourOperator;
            RefreshSelection();
            cbElementCreators.Focus();
            return ShowDialog();
        }
    }
}
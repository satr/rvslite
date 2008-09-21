using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using RVSLite.Controls;

namespace RVSLite{
    public partial class OperatorsListForm : Form{
        private readonly OperatorsController _operatorsController;
        private OperatorHolderControl _sourceOperatorHolderControl;
        private BaseOperator _newInstance;

        public OperatorsListForm(MainController mainController){
            InitializeComponent();
            InitControls(mainController);
            _operatorsController = mainController.OperatorsController;
            Bind();
            SelectedOperator = new BaseOperator();
        }

        public BaseOperator SelectedOperator { get; set; }

        private ElementCreatorBase SelectedElementCreator { get; set; }

        private bool InstancesListIsEmpty{
            get { return cbInstances.Items.Count == 0; }
        }

        private void cbInstances_SelectedIndexChanged(object sender, EventArgs e){
            RefreshSelectedInstanceProperties();
        }

        private void Bind(){
            btnAdd.Click += btnAdd_Click;
            Closing += OperationsListForm_Closing;
            cbElementCreators.SelectedValueChanged += cbElementCreators_SelectedValueChanged;
        }

        private void cbElementCreators_SelectedValueChanged(object sender, EventArgs e){
            RefreshSelection();
        }

        private void RefreshSelection(){
            SelectedElementCreator = (ElementCreatorBase) cbElementCreators.SelectedValue;
            RefreshSourceElementPanel(SelectedElementCreator);
            RefreshOperationsList(SelectedElementCreator);
            RefreshValuePanel();
            RefreshNamePanel(SelectedElementCreator);
            RefreshInstancesList(SelectedElementCreator);
            if(cbInstances.Items.Count == 0)
                return;
            SelectFirstOperatorInList();
            RefreshSelectedInstanceProperties();
        }

        private void RefreshSourceElementPanel(ElementCreatorBase elementCreator){
            pnlSourceElement.Visible = elementCreator.RequireSourceElement;
            if (!elementCreator.RequireSourceElement && _sourceOperatorHolderControl == null)
                return;
            txtSourceElementName.Text = _sourceOperatorHolderControl.Operator.Name;
        }

        private void RefreshOperationsList(ElementCreatorBase elementCreator){
            pnlOperations.Visible = elementCreator.IsOperatorWithOperation;
            if (!elementCreator.IsOperatorWithOperation)
                return;
            cbOperationsCommands.DataSource = new List<OperationsCommandBase>(((OperatorWithOperationCreatorBase) elementCreator).OperationCommands);
        }

        private void RefreshNamePanel(ElementCreatorBase elementCreator){
            pnlInstanceName.Visible = elementCreator.IsCollectable && !SelectedElementCreator.IsAnonymous;
        }

        private void RefreshValuePanel(){
            pnlValue.Visible = OperatorIsValueHolderRequiredInitValue(SelectedOperator);
        }

        private void RefreshInstancesList(ElementCreatorBase elementCreator){
            pnlInstances.Visible = elementCreator.IsOperatorWithOperation 
                || elementCreator.IsCollectable
                || elementCreator.IsPredefinedList;
            var instances = new List<BaseOperator>(elementCreator.IsOperatorWithOperation
                                                       ? elementCreator.ServiceProvider.ValueHolders
                                                       : elementCreator.Instances);
            if (elementCreator.IsCollectable)
                AddNewInstance(instances, elementCreator.Create());
            else if (elementCreator.IsOperatorWithOperation)
                AddNewInstance(instances, new DataHolder());
            cbInstances.DataSource = instances;
        }

        private void AddNewInstance(IList<BaseOperator> instances, BaseOperator newInstance){
            _newInstance = newInstance;
            instances.Insert(0, _newInstance);
        }


        private void RefreshSelectedInstanceProperties(){
            ClearTextFields();
            if (InstancesListIsEmpty)
                return;
            SelectedOperator = (BaseOperator)cbInstances.SelectedValue;
            SetInstanceNameField();
            SetValueField();
        }

        private void ClearTextFields(){
            txtValue.Text = txtInstanceName.Text = "";
            txtInstanceName.ReadOnly = true;
            lblNewInstance.Visible = false;
        }

        private void SetValueField(){
            RefreshValuePanel();
            if (SelectedOperator.IsValueHolder && ((ValueHolder)SelectedOperator).Value != null)
                txtValue.Text = ((ValueHolder) SelectedOperator).Value.ToString();
        }

        private void SetInstanceNameField(){
            txtInstanceName.Text = SelectedOperator.Name;
            var instanceIsNew = SelectedOperator == _newInstance;
            txtInstanceName.ReadOnly = !instanceIsNew;
            lblNewInstance.Visible = instanceIsNew;
        }

        private void SelectFirstOperatorInList(){
            try{
                cbInstances.SelectedIndexChanged -= cbInstances_SelectedIndexChanged;
            }
            // ReSharper disable EmptyGeneralCatchClause
            catch (Exception){
            // ReSharper restore EmptyGeneralCatchClause
            }
            cbInstances.SelectedIndex = 0;
            cbInstances.SelectedIndexChanged += cbInstances_SelectedIndexChanged;
        }

        private void btnAdd_Click(object sender, EventArgs e){
            Accept();
        }

        private void Accept(){
            if (!CheckSelectedOperatorIsValid())
                return;
            ClearErrorMessage();
            if (SelectedElementCreator.IsOperatorWithOperation){
                var operatorWithOperation = (OperatorWithOperation) SelectedElementCreator.Create();
                SelectedOperator = operatorWithOperation.InitBy((OperationsCommandBase)cbOperationsCommands.SelectedItem,
                                             (ValueHolder) cbInstances.SelectedItem);
            }
            else{
                SelectedOperator.Name = txtInstanceName.Text;
            }
            if (SelectedElementCreator.IsCollectable)
                SelectedElementCreator.Instances.Add(SelectedOperator);
            CloseFormWithResultOk();
        }

        private void CloseFormWithResultOk(){
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ClearErrorMessage(){
            initValueErrorProvider.Clear();
        }

        private bool CheckSelectedOperatorIsValid(){
            if (!SelectedOperator.IsValueHolder
                || SelectedElementCreator.IsAnonymous)
                return true;
            if (SelectedElementCreator.IsCollectable
                && (!InstanceNameIsSetCorrectAndInstanceNameIsNotInUse()))
                return false;
            if (OperatorIsValueHolderRequiredInitValue(SelectedOperator) 
                && !InitValueIsSetCorrect())
                return false;
            return true;
        }

        private static bool OperatorIsValueHolderRequiredInitValue(BaseOperator selectedOperator){
            return selectedOperator.IsValueHolder 
                   && ((ValueHolder)selectedOperator).RequireInitValue;
        }

        private bool InstanceNameIsSetCorrectAndInstanceNameIsNotInUse(){
            string name = txtInstanceName.Text.Trim();
            if (name.Length == 0) {
                initValueErrorProvider.SetError(txtInstanceName, Lang.Res.Require_init_value);
                return false;
            }
            if (SelectedElementCreator.ExistAnotherInstanceWith(name, SelectedOperator)) {
                initValueErrorProvider.SetError(txtInstanceName, Lang.Res.Name_is_already_in_use);
                return false;
            }
            SelectedOperator.Name = name;
            return true;
        }

        private bool InitValueIsSetCorrect(){
            string value = txtValue.Text.Trim();
            if (value.Length == 0) {
                initValueErrorProvider.SetError(txtValue, Lang.Res.Require_init_value);
                return false;
            }
            ((ValueHolder)SelectedOperator).Value = value;
            return true;
        }

        private void OperationsListForm_Closing(object sender, CancelEventArgs e){
            if (DialogResult == DialogResult.Cancel)
                return;
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
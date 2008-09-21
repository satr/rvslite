using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using RVSLite.Controls;

namespace RVSLite{
    public partial class OperatorsListForm : Form{
        private readonly OperatorsController _operatorsController;
        private OperatorHolderControl _sourceOperatorHolderControl;
        private BaseActivity _newInstance;

        public OperatorsListForm(MainController mainController){
            InitializeComponent();
            InitControls(mainController);
            _operatorsController = mainController.OperatorsController;
            Bind();
            SelectedActivity = new BaseActivity();
        }

        public BaseActivity SelectedActivity { get; set; }

        private ActivityCreatorBase SelectedActivityCreator { get; set; }

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
            SelectedActivityCreator = (ActivityCreatorBase) cbElementCreators.SelectedValue;
            RefreshSourceElementPanel(SelectedActivityCreator);
            RefreshOperationsList(SelectedActivityCreator);
            RefreshValuePanel();
            RefreshNamePanel(SelectedActivityCreator);
            RefreshInstancesList(SelectedActivityCreator);
            if(cbInstances.Items.Count == 0)
                return;
            SelectFirstOperatorInList();
            RefreshSelectedInstanceProperties();
        }

        private void RefreshSourceElementPanel(ActivityCreatorBase activityCreator){
            pnlSourceElement.Visible = activityCreator.RequireSourceElement;
            if (!activityCreator.RequireSourceElement && _sourceOperatorHolderControl == null)
                return;
            txtSourceElementName.Text = _sourceOperatorHolderControl.Activity.Name;
        }

        private void RefreshOperationsList(ActivityCreatorBase activityCreator){
            pnlOperations.Visible = activityCreator.IsOperatorWithOperation;
            if (!activityCreator.IsOperatorWithOperation)
                return;
            cbOperationsCommands.DataSource = new List<OperationsCommandBase>(((ActivityWithOperationCreatorBase) activityCreator).OperationCommands);
        }

        private void RefreshNamePanel(ActivityCreatorBase activityCreator){
            pnlInstanceName.Visible = activityCreator.IsCollectable && !SelectedActivityCreator.IsAnonymous;
        }

        private void RefreshValuePanel(){
            pnlValue.Visible = OperatorIsValueHolderRequiredInitValue(SelectedActivity);
        }

        private void RefreshInstancesList(ActivityCreatorBase activityCreator){
            pnlInstances.Visible = activityCreator.IsOperatorWithOperation 
                || activityCreator.IsCollectable
                || activityCreator.IsPredefinedList;
            var instances = new List<BaseActivity>(activityCreator.IsOperatorWithOperation
                                                       ? activityCreator.ServiceProvider.ValueHolders
                                                       : activityCreator.Instances);
            if (activityCreator.IsCollectable)
                AddNewInstance(instances, activityCreator.Create());
            else if (activityCreator.IsOperatorWithOperation)
                AddNewInstance(instances, new Data());
            cbInstances.DataSource = instances;
        }

        private void AddNewInstance(IList<BaseActivity> instances, BaseActivity newInstance){
            _newInstance = newInstance;
            instances.Insert(0, _newInstance);
        }


        private void RefreshSelectedInstanceProperties(){
            ClearTextFields();
            if (InstancesListIsEmpty)
                return;
            SelectedActivity = (BaseActivity)cbInstances.SelectedValue;
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
            if (SelectedActivity.IsValueHolder && ((Variable)SelectedActivity).Value != null)
                txtValue.Text = ((Variable) SelectedActivity).Value.ToString();
        }

        private void SetInstanceNameField(){
            txtInstanceName.Text = SelectedActivity.Name;
            var instanceIsNew = SelectedActivity == _newInstance;
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
            if (SelectedActivityCreator.IsOperatorWithOperation){
                var operatorWithOperation = (ActivityWithOperation) SelectedActivityCreator.Create();
                SelectedActivity = operatorWithOperation.InitBy((OperationsCommandBase)cbOperationsCommands.SelectedItem,
                                             (Variable) cbInstances.SelectedItem);
            }
            else{
                SelectedActivity.Name = txtInstanceName.Text;
            }
            if (SelectedActivityCreator.IsCollectable)
                SelectedActivityCreator.Instances.Add(SelectedActivity);
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
            if (!SelectedActivity.IsValueHolder
                || SelectedActivityCreator.IsAnonymous)
                return true;
            if (SelectedActivityCreator.IsCollectable
                && (!InstanceNameIsSetCorrectAndInstanceNameIsNotInUse()))
                return false;
            if (OperatorIsValueHolderRequiredInitValue(SelectedActivity) 
                && !InitValueIsSetCorrect())
                return false;
            return true;
        }

        private static bool OperatorIsValueHolderRequiredInitValue(BaseActivity selectedActivity){
            return selectedActivity.IsValueHolder 
                   && ((Variable)selectedActivity).RequireInitValue;
        }

        private bool InstanceNameIsSetCorrectAndInstanceNameIsNotInUse(){
            string name = txtInstanceName.Text.Trim();
            if (name.Length == 0) {
                initValueErrorProvider.SetError(txtInstanceName, Lang.Res.Require_init_value);
                return false;
            }
            if (SelectedActivityCreator.ExistAnotherInstanceWith(name, SelectedActivity)) {
                initValueErrorProvider.SetError(txtInstanceName, Lang.Res.Name_is_already_in_use);
                return false;
            }
            SelectedActivity.Name = name;
            return true;
        }

        private bool InitValueIsSetCorrect(){
            string value = txtValue.Text.Trim();
            if (value.Length == 0) {
                initValueErrorProvider.SetError(txtValue, Lang.Res.Require_init_value);
                return false;
            }
            ((Variable)SelectedActivity).Value = value;
            return true;
        }

        private void OperationsListForm_Closing(object sender, CancelEventArgs e){
            if (DialogResult == DialogResult.Cancel)
                return;
        }

        private void InitControls(MainController mainController){
            cbElementCreators.DisplayMember = "Name";
            cbElementCreators.DataSource = mainController.BasicActivities;
        }

        public DialogResult ActivateFor(OperatorHolderControl operatorHolderControl){
            _sourceOperatorHolderControl = operatorHolderControl.NearestNeighbourOperator;
            RefreshSelection();
            cbElementCreators.Focus();
            return ShowDialog();
        }
    }
}
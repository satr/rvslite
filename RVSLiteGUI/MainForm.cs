using System;
using System.Windows.Forms;
using RVSLite.Controls;
using RVSLite.HardwareDevices;

namespace RVSLite{
    public partial class MainForm : Form{
        private readonly MainController _mainController;
        private readonly OperationsListForm _operationsListForm;
        public MainForm(){
            Lang.SwitchToRu();
            InitializeComponent();
            _mainController = new MainController(GetHardware());
            _operationsListForm = new OperationsListForm(_mainController);
            InitGroundControls();
            
        }

        private HardwareInterface GetHardware() {
            var hardware = new HardwareInterface();
            hardware.Bumpers = new[]{new HWTrigger(bumperControl1),new HWTrigger(bumperControl2)};
            hardware.SetLEDs(ledControl1, ledControl2);
            return hardware;
        }

        private void InitGroundControls(){
            var columnCount = tableLayoutPanel.ColumnCount;
            var rowCount = tableLayoutPanel.RowCount;
            _mainController.InitOperatorsListBy(columnCount,rowCount);
            for (int column = 0; column < columnCount; column++) {
                for (int row = 0; row < rowCount; row++){
                    var operatorHolderControl = new OperatorHolderControl();
                    tableLayoutPanel.Controls.Add(operatorHolderControl, column, row);
                    operatorHolderControl.OnHolderClick += operatorHolderControl_Click;
                }
            }
        }

        private void operatorHolderControl_Click(object sender, EventArgs e){
            var operatorHolderControl = (OperatorHolderControl)sender;
            if (operatorHolderControl.Operator != null)
                return;
            if (_operationsListForm.ShowDialog() == DialogResult.Cancel)
                return;
            var position = tableLayoutPanel.GetCellPosition(operatorHolderControl);
            var selectedOperator = _operationsListForm.SelectedOperator;
            _mainController.PlaceOperatorAt(selectedOperator, position.Column, position.Row);
            operatorHolderControl.Operator = selectedOperator;
        }
    }
}
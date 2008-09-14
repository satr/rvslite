using System;
using System.Windows.Forms;
using RVSLite.Controls;

namespace RVSLite{
    public partial class MainForm : Form{
        private readonly MainController _mainController;
        private readonly OperationsListForm _operationsListForm;
        public MainForm(){
            Lang.SwitchToRu();
            InitializeComponent();
            _mainController = new MainController(new HardwareInterface(ctrlBumper, ctrlLED1));
            _operationsListForm = new OperationsListForm(_mainController);
            InitGroundControls();
            
        }

        private void InitGroundControls(){
            var columnCount = tableLayoutPanel.ColumnCount;
            var rowCount = tableLayoutPanel.RowCount;
            _mainController.ServiceCoordinator.Operators = new OperatorBase[columnCount,rowCount];
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
            operatorHolderControl.Operator = _operationsListForm.SelectedOperator;
        }
    }
}
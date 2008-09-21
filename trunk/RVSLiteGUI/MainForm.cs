using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RVSLite.Controls;

namespace RVSLite{
    public partial class MainForm : Form{
        private readonly MainController _mainController;
        private readonly OperatorsListForm _operatorsListForm;
        public MainForm(){
            Lang.SwitchToRu();
            InitializeComponent();
            _mainController = new MainController(GetServices());
            _operatorsListForm = new OperatorsListForm(_mainController);
            InitGroundControls();
            new DesignerForm(_mainController).ShowDialog();
        }

        private ServiceProvider GetServices() {
            var serviceProvider = new ServiceProvider();
            serviceProvider.BumperPorts = new List<IService>{bumperControl1, bumperControl2};
            serviceProvider.LEDPorts = new List<IService>{ledControl1, ledControl2};
            serviceProvider.DrivePorts = new List<IService>{driveControl1, driveControl2};
            return serviceProvider;
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
            for (int column = 0; column < columnCount; column++) {
                for (int row = 0; row < rowCount; row++)
                    InitNeighboursBy(column, row, (OperatorHolderControl) tableLayoutPanel.GetControlFromPosition(column, row));
            }
        }

        private void InitNeighboursBy(int column, int row, OperatorHolderControl operatorHolderControl){
            foreach (var direction in OperatorHolderControl.GetNeighbourDirections())
                operatorHolderControl.Neihgbours[direction] = GetNeighboursBy(column, row, direction, tableLayoutPanel);
        }

        private static OperatorHolderControl GetNeighboursBy(int column, int row, NeighbourDirections direction, TableLayoutPanel tableLayoutPanel){
            if (direction == NeighbourDirections.Left)
                return (OperatorHolderControl) (column == 0 ? null : tableLayoutPanel.GetControlFromPosition(column - 1, row));
            if (direction == NeighbourDirections.Right)
                return (OperatorHolderControl) (column == tableLayoutPanel.ColumnCount ? null : tableLayoutPanel.GetControlFromPosition(column + 1, row));
            if (direction == NeighbourDirections.Top)
                return (OperatorHolderControl) (row == 0 ? null : tableLayoutPanel.GetControlFromPosition(column, row - 1));
            return (OperatorHolderControl) (row == tableLayoutPanel.RowCount ? null : tableLayoutPanel.GetControlFromPosition(column, row + 1));
        }

        private void operatorHolderControl_Click(object sender, EventArgs e){
            var operatorHolderControl = (OperatorHolderControl)sender;
            var position = tableLayoutPanel.GetCellPosition(operatorHolderControl);
            if (operatorHolderControl.Activity != null)
                return;
            if (_operatorsListForm.ActivateFor(operatorHolderControl) == DialogResult.Cancel)
                return;
            var selectedOperator = _operatorsListForm.SelectedActivity;
            _mainController.RegisterActivityAt(selectedOperator, position.Column, position.Row);
            operatorHolderControl.Activity = selectedOperator;
        }

    }

    internal class OperatorHolderControlNeighbours{
    }
}
using System;
using System.Collections.Generic;

namespace RVSLite{
    public class OperatorsController{
        private readonly IServiceProvider _serviceProvider;
        private int _columnCount;
        private int _rowCount;

        public OperatorsController(IServiceProvider serviceProvider){
            Operators = new BaseOperator[0,0];
            if (serviceProvider == null)
                return;
           _serviceProvider = serviceProvider;
        }

        public IServiceProvider ServiceProvider{
            get { return _serviceProvider; }
        }

        public BaseOperator[,] Operators { get; set; }

        public void PlaceOperatorAt(BaseOperator oper, int column, int row){
            Operators[column, row] = oper;
            ConnectToNeighbours(oper, column, row);
        }

        private void ConnectToNeighbours(BaseOperator oper, int column, int row){
            foreach (NeighbourDirections direction in new[]{NeighbourDirections.Left, NeighbourDirections.Top, NeighbourDirections.Bottom, NeighbourDirections.Right}){
                if (ConnectToNeighboursBy(column, row, oper, direction))
                    return;
            }
        }

        private bool ConnectToNeighboursBy(int column, int row, BaseOperator oper, NeighbourDirections direction){
            BaseOperator neighbourOperator = GetNeighbourOperatorBy(column, row, direction);
            if (neighbourOperator == null)
                return false;
            oper.ListenTo(neighbourOperator);
            return true;
        }

        private BaseOperator GetNeighbourOperatorBy(int column, int row, NeighbourDirections direction){
            if (direction == NeighbourDirections.Left)
                return column == 0 ? null : Operators[column - 1, row];
            if (direction == NeighbourDirections.Right)
                return column == _columnCount ? null : Operators[column + 1, row];
            if (direction == NeighbourDirections.Top)
                return row == 0 ? null : Operators[column, row - 1];
            return row == _rowCount ? null : Operators[column, row + 1];
        }

        public void InitOperatorsListBy(int columnCount, int rowCount){
            Operators = new BaseOperator[columnCount,rowCount];
            _columnCount = columnCount;
            _rowCount = rowCount;
        }
    }
}
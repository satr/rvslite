using System;
using System.Collections.Generic;

namespace RVSLite{
    public class ActivitiesController{
        private readonly IServiceProvider _serviceProvider;
        private int _columnCount;
        private int _rowCount;

        public ActivitiesController(IServiceProvider serviceProvider){
            Activities = new BaseActivity[20,20];
            if (serviceProvider == null)
                return;
           _serviceProvider = serviceProvider;
        }

        public IServiceProvider ServiceProvider{
            get { return _serviceProvider; }
        }

        public BaseActivity[,] Activities { get; set; }

        public void PlaceOperatorAt(BaseActivity oper, int column, int row){
            Activities[column, row] = oper;
            ConnectToNeighbours(oper, column, row);
        }

        private void ConnectToNeighbours(BaseActivity oper, int column, int row){
            foreach (NeighbourDirections direction in new[]{NeighbourDirections.Left, NeighbourDirections.Top, NeighbourDirections.Bottom, NeighbourDirections.Right}){
                if (ConnectToNeighboursBy(column, row, oper, direction))
                    return;
            }
        }

        private bool ConnectToNeighboursBy(int column, int row, BaseActivity oper, NeighbourDirections direction){
            var neighbourActivity = GetNeighbourOperatorBy(column, row, direction);
            if (neighbourActivity == null)
                return false;
            oper.ListenTo(neighbourActivity);
            return true;
        }

        private BaseActivity GetNeighbourOperatorBy(int column, int row, NeighbourDirections direction){
            if (direction == NeighbourDirections.Left)
                return column == 0 ? null : Activities[column - 1, row];
            if (direction == NeighbourDirections.Right)
                return column == _columnCount ? null : Activities[column + 1, row];
            if (direction == NeighbourDirections.Top)
                return row == 0 ? null : Activities[column, row - 1];
            return row == _rowCount ? null : Activities[column, row + 1];
        }

        public void InitOperatorsListBy(int columnCount, int rowCount){
            Activities = new BaseActivity[columnCount,rowCount];
            _columnCount = columnCount;
            _rowCount = rowCount;
        }
    }
}
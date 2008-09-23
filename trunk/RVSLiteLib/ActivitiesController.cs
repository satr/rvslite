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

//        private bool ConnectToNeighboursBy(int column, int row, BaseActivity oper, NeighbourDirections direction){
//            var neighbourActivity = GetNeighbourActivityBy(column, row, direction);
//            if (neighbourActivity == null)
//                return false;
//            oper.ListenTo(neighbourActivity);
//            return true;
//        }

        private BaseActivity GetNeighbourActivityBy(int column, int row, NeighbourDirections direction){
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

        public BaseActivity GetSourceNeighbourActivityBy(int column, int row){
            foreach (NeighbourDirections direction in GetNeighbourDirections()){
                BaseActivity activity = GetNeighbourActivityBy(column, row, direction);
                if (activity != null)
                    return activity;
            }
            return null;
        }

        private static NeighbourDirections[] GetNeighbourDirections(){
            return new[]{
                            NeighbourDirections.Left, NeighbourDirections.Top, NeighbourDirections.Bottom,
                            NeighbourDirections.Right
                        };
        }
    }
}
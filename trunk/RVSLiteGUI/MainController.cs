using System.Collections.Generic;

namespace RVSLite {
    public class MainController {
        private readonly ServiceProvider _serviceProvider;
        private readonly OperatorsController _operatorsController;
        public const int CellWH = 100;

        public MainController(ServiceProvider serviceProvider) {
            _serviceProvider = serviceProvider;
            _operatorsController = new OperatorsController(_serviceProvider);
            InitActivitiesList();

        }

        public List<ActivityCreatorBase> BasicActivities { get; private set; }
        public IEnumerable<ActivityCreatorBase> Services { get; private set; }

        public OperatorsController OperatorsController {
            get { return _operatorsController; }
        }


        private void InitActivitiesList() {
            BasicActivities = new List<ActivityCreatorBase>
                       {
                           new DataActivityCreator(_operatorsController.ServiceProvider),
                           new VariableActivityCreator(_operatorsController.ServiceProvider),
                           new ConnectionActivityCreator(_operatorsController.ServiceProvider),
                           new IfClauseActivityCreator(_operatorsController.ServiceProvider),
                           new CalculateActivityCreator(_operatorsController.ServiceProvider),
                           new PauseActivityCreator(_operatorsController.ServiceProvider),
                       };
            Services = new List<ActivityCreatorBase>
                       {
                           new BumperServiceCreator(_operatorsController.ServiceProvider),
                           new DriveServiceCreator(_operatorsController.ServiceProvider),
                           new LEDServiceCreator(_operatorsController.ServiceProvider)
                       };
        }

        public void InitOperatorsListBy(int columnCount, int rowCount) {
            OperatorsController.InitOperatorsListBy(columnCount, rowCount);
        }

        public void RegisterActivityAt(BaseActivity oper, int column, int row) {
            OperatorsController.PlaceOperatorAt(oper, column, row);
        }
    }
}
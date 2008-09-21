using System.Collections.Generic;

namespace RVSLite {
    public class MainController {
        private readonly ServiceProvider _serviceProvider;
        private readonly ActivitiesController _activitiesController;
        public const int CellWH = 100;

        public MainController(ServiceProvider serviceProvider) {
            _serviceProvider = serviceProvider;
            _activitiesController = new ActivitiesController(_serviceProvider);
            InitActivitiesList();

        }

        public List<ActivityCreatorBase> BasicActivities { get; private set; }
        public IEnumerable<ActivityCreatorBase> Services { get; private set; }

        public ActivitiesController ActivitiesController {
            get { return _activitiesController; }
        }


        private void InitActivitiesList() {
            BasicActivities = new List<ActivityCreatorBase>
                       {
                           new DataActivityCreator(_activitiesController.ServiceProvider),
                           new VariableActivityCreator(_activitiesController.ServiceProvider),
                           new ConnectionActivityCreator(_activitiesController.ServiceProvider),
                           new JoinActivityCreator(_activitiesController.ServiceProvider),
                           new IfClauseActivityCreator(_activitiesController.ServiceProvider),
                           new CalculateActivityCreator(_activitiesController.ServiceProvider),
                           new PauseActivityCreator(_activitiesController.ServiceProvider),
                       };
            Services = new List<ActivityCreatorBase>
                       {
                           new BumperServiceCreator(_activitiesController.ServiceProvider),
                           new DriveServiceCreator(_activitiesController.ServiceProvider),
                           new LEDServiceCreator(_activitiesController.ServiceProvider)
                       };
        }

        public void InitOperatorsListBy(int columnCount, int rowCount) {
            ActivitiesController.InitOperatorsListBy(columnCount, rowCount);
        }

        public void RegisterActivityAt(BaseActivity oper, int column, int row) {
            ActivitiesController.PlaceOperatorAt(oper, column, row);
        }
    }
}
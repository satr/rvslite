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
            ActivityControls = new IActivityControl[20, 20];
        }

        public List<ActivityCreatorBase> BasicActivities { get; private set; }
        public IEnumerable<ActivityCreatorBase> Services { get; private set; }

        public ActivitiesController ActivitiesController {
            get { return _activitiesController; }
        }

        public IActivityControl[,] ActivityControls { get; private set; }


        private void InitActivitiesList() {
            BasicActivities = new List<ActivityCreatorBase>
                       {
                           new StartActivityCreator(_activitiesController.ServiceProvider),
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
                           new LEDServiceCreator(_activitiesController.ServiceProvider),
                           new MessengerServiceCreator(_activitiesController.ServiceProvider)
                       };
        }

        public void InitOperatorsListBy(int columnCount, int rowCount) {
            ActivitiesController.InitOperatorsListBy(columnCount, rowCount);
        }
    }
}
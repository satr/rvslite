using System.Collections.Generic;

namespace RVSLite {
    public class MainController {
        private readonly ServiceProvider _serviceProvider;
        private readonly List<ElementCreatorBase> _operatorsList;
        private readonly ServiceCoordinator _serviceCoordinator;

        public MainController(ServiceProvider serviceProvider) {
            _serviceProvider = serviceProvider;
            _serviceCoordinator = new ServiceCoordinator(_serviceProvider);
            _operatorsList = InitOperatorsList();
//            _serviceCoordinator.Subscribe();
        }

        public IEnumerable<ElementCreatorBase> OperatorCreatorsList {
            get { return _operatorsList; }
        }

        public ServiceCoordinator ServiceCoordinator {
            get { return _serviceCoordinator; }
        }

        private List<ElementCreatorBase> InitOperatorsList() {
            return new List<ElementCreatorBase>
                       {
                           new ConnectionOperatorCreator(_serviceCoordinator.ServiceProvider),
                           new BumperOperatorCreator(_serviceCoordinator.ServiceProvider),
                           new DriveOperatorCreator(_serviceCoordinator.ServiceProvider),
                           new LEDServiceCreator(_serviceCoordinator.ServiceProvider)
                       };
        }

        public void InitOperatorsListBy(int columnCount, int rowCount) {
            ServiceCoordinator.InitOperatorsListBy(columnCount, rowCount);
        }

        public void PlaceOperatorAt(OperatorBase oper, int column, int row) {
            ServiceCoordinator.PlaceOperatorAt(oper, column, row);
        }
    }
}
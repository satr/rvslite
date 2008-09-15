using System.Collections.Generic;

namespace RVSLite {
    public class MainController {
        private readonly HardwareInterface _hwInterface;
        private readonly List<OperatorCreatorBase> _operatorsList;
        private readonly ServiceCoordinator _serviceCoordinator;

        public MainController(HardwareInterface hwInterface) {
            _hwInterface = hwInterface;
            _serviceCoordinator = new ServiceCoordinator(_hwInterface);
            _operatorsList = InitOperatorsList();
//            _serviceCoordinator.Subscribe();
        }

        public IEnumerable<OperatorCreatorBase> OperatorCreatorsList {
            get { return _operatorsList; }
        }

        public ServiceCoordinator ServiceCoordinator {
            get { return _serviceCoordinator; }
        }

        private List<OperatorCreatorBase> InitOperatorsList() {
            return new List<OperatorCreatorBase>
                       {
                           new ConnectionOperatorCreator(_serviceCoordinator.Hardware),
                           new BumperOperatorCreator(_serviceCoordinator.Hardware),
                           new DriveOperatorCreator(_serviceCoordinator.Hardware),
                           new LEDOperatorCreator(_serviceCoordinator.Hardware)
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
using System.Collections.Generic;

namespace RVSLite {
    public class MainController {
        private readonly ServiceProvider _serviceProvider;
        private readonly List<ElementCreatorBase> _operatorsList;
        private readonly OperatorsController _operatorsController;

        public MainController(ServiceProvider serviceProvider) {
            _serviceProvider = serviceProvider;
            _operatorsController = new OperatorsController(_serviceProvider);
            _operatorsList = InitOperatorsList();
        }

        public IEnumerable<ElementCreatorBase> OperatorCreatorsList {
            get { return _operatorsList; }
        }

        public OperatorsController OperatorsController {
            get { return _operatorsController; }
        }

        private List<ElementCreatorBase> InitOperatorsList() {
            return new List<ElementCreatorBase>
                       {
                           new DataHolderOperatorCreator(_operatorsController.ServiceProvider),
                           new ValueHolderOperatorCreator(_operatorsController.ServiceProvider),
                           new ConnectionOperatorCreator(_operatorsController.ServiceProvider),
                           new IfClauseOperatorCreator(_operatorsController.ServiceProvider),
                           new CalculateOperatorCreator(_operatorsController.ServiceProvider),
                           new PauseOperatorCreator(_operatorsController.ServiceProvider),
                           new BumperOperatorCreator(_operatorsController.ServiceProvider),
                           new DriveOperatorCreator(_operatorsController.ServiceProvider),
                           new LEDServiceCreator(_operatorsController.ServiceProvider)
                       };
        }

        public void InitOperatorsListBy(int columnCount, int rowCount) {
            OperatorsController.InitOperatorsListBy(columnCount, rowCount);
        }

        public void PlaceOperatorAt(BaseOperator oper, int column, int row) {
            OperatorsController.PlaceOperatorAt(oper, column, row);
        }
    }
}
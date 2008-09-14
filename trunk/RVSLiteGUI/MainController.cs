using System.Collections;
using System.Collections.Generic;

namespace RVSLite{
    public class MainController{
        private readonly HardwareInterface _hwInterface;
        private readonly List<OperatorCreatorBase> _operatorsList;
        private readonly ServiceCoordinator _serviceCoordinator;

        public MainController(HardwareInterface hwInterface){
            _hwInterface = hwInterface;
            _operatorsList  = InitOperatorsList();
            _serviceCoordinator = new ServiceCoordinator(_hwInterface);
            _serviceCoordinator.Subscribe();
        }

        private static List<OperatorCreatorBase> InitOperatorsList(){
            return new List<OperatorCreatorBase>(){
                                               new DriveOperatorCreator(),
                                               new LEDOperatorCreator()
                                           };
        }

        public IEnumerable<OperatorCreatorBase> OperatorCreatorsList{
            get{
                return _operatorsList;
            }
        }

        public ServiceCoordinator ServiceCoordinator{
            get { return _serviceCoordinator; }
        }
    }
}
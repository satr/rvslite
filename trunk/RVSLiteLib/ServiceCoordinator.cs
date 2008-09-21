using System;
using System.Collections.Generic;

namespace RVSLite{
    public class ServiceCoordinator{
//        private const string BOOL_CONDITION_OPERATION_DEMO_ACTION_ID = "8";
//        private const string PRESS_RELEASE_BUMPER_DEMO_ACTION_ID = "1";
//        private const string CLEAR_DISPLAY_DEMO_ACTION_ID = "c";
//        private const string CYCLIC_SOUND_DEMO_ACTION_ID = "9";
//        private const string DISCONECT_LED2_SERVICE_EVENT_ID = "4";
//        private const string DISPLAY_VALUE_DEMO_ACTION_ID = "3";
//        private const string EXIT_EVENT_ID = "q";
//        private const string INT_CONDITION_OPERATION_DEMO_ACTION_ID = "7";
//        private const string RUN_DRIVE_DEMO_ACTION_ID = "5";
//        private const string SET_VALUE_DEMO_ACTION_ID = "2";
//        private const string SOUND_DEMO_ACTION_ID = "6";
//        private readonly IServiceProvider _serviceProvider;
//        private readonly Dictionary<string, BaseActivity> _demoActions = new Dictionary<string, BaseActivity>();
//        private int _columnCount;
//        private BaseActivity _ledNo2Operator;
//        private int _rowCount;
//        private ValueReceiver _valueReceiver = new ValueReceiver();
//        private readonly Data _bumperState = new Data(false);
//
//        public ServiceCoordinator(IServiceProvider serviceProvider){
//            Activities = new BaseActivity[0,0];
//            if (serviceProvider == null)
//                return;
//           _serviceProvider = serviceProvider;
//        }
//
//        public IServiceProvider ServiceProvider{
//            get { return _serviceProvider; }
//        }
//
//        public BaseActivity[,] Activities { get; set; }
//
//        public void Start(){
//            for (;;){
//                Console.Out.WriteLine(Lang.Res.InteractionHelp);
//                string choice = GetChoice();
//                switch (choice){
//                    case EXIT_EVENT_ID:
//                        return;
//                    case DISCONECT_LED2_SERVICE_EVENT_ID:
//                        _ledNo2Operator.Disconnect();
//                        break;
//                    default:
//                        GetServiceBy(choice).Post(null);
//                        if (choice == PRESS_RELEASE_BUMPER_DEMO_ACTION_ID)
//                            _bumperState.Value = !(bool)_bumperState.Value;
//                        break;
//                }
//            }
//        }
//
//        private static string GetChoice(){
//            return Console.In.ReadLine().ToLower();
//        }
//
//        private BaseActivity GetServiceBy(string sensorId){
//            if (!_demoActions.ContainsKey(sensorId))
//                return new NullOperator();
//            return _demoActions[sensorId];
//        }
//
//        private void RegisterInteractiveServiceTo(string serviceId, BaseActivity op){
//            _demoActions[serviceId] = op;
//        }
//
//        public void Subscribe(){
//            InteractionWithBumper();
//            ClearDisplay();
//            ReceiveValue();
//            DisplayReceivedValue();
//            ControlOfDrive();
//            DemoStartSound3Times();
//            DemoIntConditionOperation();
//            DemoBoolConditionOperation();
//            StartCyclicSound();
//        }
//
//        public void PlaceOperatorAt(BaseActivity oper, int column, int row){
//            Activities[column, row] = oper;
//            ConnectToNeighbours(oper, column, row);
//        }
//
//        private void ConnectToNeighbours(BaseActivity oper, int column, int row){
//            foreach (NeighbourDirections direction in new[]{NeighbourDirections.Left, NeighbourDirections.Top, NeighbourDirections.Bottom, NeighbourDirections.Right}){
//                if (ConnectToNeighboursBy(column, row, oper, direction))
//                    return;
//            }
//        }
//
//        private bool ConnectToNeighboursBy(int column, int row, BaseActivity oper, NeighbourDirections direction){
//            BaseActivity neighbourOperator = GetNeighbourOperatorBy(column, row, direction);
//            if (neighbourOperator == null)
//                return false;
//            oper.ListenTo(neighbourOperator);
//            return true;
//        }
//
//        private BaseActivity GetNeighbourOperatorBy(int column, int row, NeighbourDirections direction){
//            if (direction == NeighbourDirections.Left)
//                return column == 0 ? null : Activities[column - 1, row];
//            if (direction == NeighbourDirections.Right)
//                return column == _columnCount ? null : Activities[column + 1, row];
//            if (direction == NeighbourDirections.Top)
//                return row == 0 ? null : Activities[column, row - 1];
//            return row == _rowCount ? null : Activities[column, row + 1];
//        }
//
//        public void InitOperatorsListBy(int columnCount, int rowCount){
//            Activities = new BaseActivity[columnCount,rowCount];
//            _columnCount = columnCount;
//            _rowCount = rowCount;
//        }
//
//        #region ServiceProvider
//
//        private void DemoIntConditionOperation(){
//            var value1 = new IntegerValueReceiver();
//            RegisterInteractiveServiceTo(INT_CONDITION_OPERATION_DEMO_ACTION_ID, value1);
//            var value2 = new IntegerValueReceiver();
//            value2.ListenTo(value1);
//            var ifClause = new IfClause(value1, ConditionOperations.LessThan, value2);
//            ifClause.ListenTo(value2);
//            new Messenger(Lang.Res.Result).ListenTo(ifClause.Positive);
//            new Messenger(Lang.Res.Result).ListenTo(ifClause.Negative);
//        }
//
//        private void DemoBoolConditionOperation(){
//            var bumper = new Bumper();
//            RegisterInteractiveServiceTo(BOOL_CONDITION_OPERATION_DEMO_ACTION_ID, bumper);
//            var ifClause = new IfClause(bumper);
//            ifClause.ListenTo(bumper);
//            var value = new Variable();
//            var valueSetter1 = new ValueSetter(value, new Data(100));
//            valueSetter1.ListenTo(ifClause.Positive);
//            var valueSetter2 = new ValueSetter(value, new Data(200));
//            valueSetter2.ListenTo(ifClause.Negative);
//            var join = new Join();
//            join.ListenTo(valueSetter1);
//            join.ListenTo(valueSetter2);
//            new Messenger(Lang.Res.Result, value).ListenTo(join);
//        }
//
//        private void StartCyclicSound(){
//            var soundTone = new Variable(Lang.Res.SoundTone, 100);
//            var soundToneInitializer = new ValueSetter(soundTone, new Data(100));
//            RegisterInteractiveServiceTo(CYCLIC_SOUND_DEMO_ACTION_ID, soundToneInitializer);
//            soundTone.ListenTo(soundToneInitializer);
//            var ifClause = new IfClause(soundTone, ConditionOperations.LessThan, new Data(200));
//            ifClause.ListenTo(soundTone);
//            var sound = new Sound(soundTone);
//            sound.ListenTo(ifClause.Positive);
//            var pause = new Pause(100);
//            pause.ListenTo(sound);
//            var calculate = new Calculate(soundTone, CalculationOperations.Sum, new Data(20), soundTone);
//            calculate.ListenTo(pause);
//            ifClause.ListenTo(calculate);
//            new Messenger(new Data(Lang.Res.Finished)).ListenTo(ifClause.Negative);
//        }
//
//        private void DemoStartSound3Times(){
//            var sound1 = new Sound(100);
//            RegisterInteractiveServiceTo(SOUND_DEMO_ACTION_ID, sound1);
//            var pause1 = new Pause(new Variable(500));
//            pause1.ListenTo(sound1);
//            var tone = new Variable(Lang.Res.SoundTone, 200);
//            var sound2 = new Sound(tone);
//            sound2.ListenTo(pause1);
//            var pause2 = new Pause(2300);
//            pause2.ListenTo(sound2);
//            var calculate = new Calculate(tone, CalculationOperations.Sum, new Variable(Lang.Res.Constant, 25), tone);
//            calculate.ListenTo(pause2);
//            var sound3 = new Sound(tone);
//            sound3.ListenTo(calculate);
//        }
//
//        private void ControlOfDrive(){
//            var integerReceiver = new IntegerValueReceiver(-1, 1);
//            RegisterInteractiveServiceTo(RUN_DRIVE_DEMO_ACTION_ID, integerReceiver);
//            new Messenger().ListenTo(integerReceiver);
//            new Drive().ListenTo(integerReceiver);
//        }
//
//        private void DisplayReceivedValue(){
//            var valueReceiverMessenger = new Messenger(_valueReceiver);
//            RegisterInteractiveServiceTo(DISPLAY_VALUE_DEMO_ACTION_ID, valueReceiverMessenger);
//        }
//
//        private void ReceiveValue(){
//            _valueReceiver = new ValueReceiver();
//            RegisterInteractiveServiceTo(SET_VALUE_DEMO_ACTION_ID, _valueReceiver);
//            new Messenger().ListenTo(_valueReceiver);
//        }
//
//        private void ClearDisplay(){
//            RegisterInteractiveServiceTo(CLEAR_DISPLAY_DEMO_ACTION_ID, new ClearDisplay());
//        }
//
//        private void InteractionWithBumper(){
//            var bumper = new Bumper();
//            var bumperSetter = new ValueSetter(bumper, _bumperState);
//            RegisterInteractiveServiceTo(PRESS_RELEASE_BUMPER_DEMO_ACTION_ID, bumperSetter);
//            bumper.ListenTo(bumperSetter);
//            new Messenger().ListenTo(bumper);
//            new LED().ListenTo(bumper);
//            var valueNegator = new ValueNegator();
//            valueNegator.ListenTo(bumper);
//            _ledNo2Operator = new LED();
//            _ledNo2Operator.ListenTo(valueNegator);
//        }
//
//        #endregion
    }
}
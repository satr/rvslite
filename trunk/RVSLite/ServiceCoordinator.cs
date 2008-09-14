using System;
using System.Collections.Generic;

namespace RVSLite{
    public class ServiceCoordinator{
        private const string BOOL_CONDITION_OPERATION_SERVICE_ID = "8";
        private const string BUMPER_SERVICE_ID = "1";
        private const string CLEAR_DISPLAY_SERVICE_ID = "c";
        private const string CYCLIC_SOUND_SERVICE_ID = "9";
        private const string DISCONECT_LED2_SERVICE_EVENT_ID = "4";
        private const string DISPLAY_VALUE_SERVICE_ID = "3";
        private const string EXIT_EVENT_ID = "q";
        private const string SOUND_SERVICE_ID = "6";
        private const string INT_CONDITION_OPERATION_SERVICE_ID = "7";
        private const string RUN_DRIVE_SERVICE_ID = "5";
        private const string SET_VALUE_SERVICE_ID = "2";
        private readonly Dictionary<string, OperatorBase> _services = new Dictionary<string, OperatorBase>();
        private OperatorBase _ledNo2Operator;
        private ValueReceiver _valueReceiver = new ValueReceiver();

        public void Start(){
            for (;;){
                Console.Out.WriteLine(Lang.Res.InteractionHelp);
                string choice = GetChoice();
                switch (choice){
                    case EXIT_EVENT_ID:
                        return;
                    case DISCONECT_LED2_SERVICE_EVENT_ID:
                        _ledNo2Operator.Disconnect();
                        break;
                    default:
                        GetServiceBy(choice).Post();
                        break;
                }
            }
        }

        private static string GetChoice(){
            return Console.In.ReadLine().ToLower();
        }

        private OperatorBase GetServiceBy(string sensorId){
            if (!_services.ContainsKey(sensorId))
                return new NullOperator();
            return _services[sensorId];
        }

        private void RegisterInteractiveServiceTo(string serviceId, OperatorBase op){
            _services[serviceId] = op;
        }

        public void Subscribe(){
            InteractionWithBumper();
            ClearDisplay();
            ReceiveValue();
            DisplayReceivedValue();
            ControlOfDrive();
            DemoStartSound3Times();
            DemoIntConditionOperation();
            DemoBoolConditionOperation();
            StartCyclicSound();
        }

        #region Services

        private void DemoIntConditionOperation(){
            var value1 = new IntegerValueReceiver();
            RegisterInteractiveServiceTo(INT_CONDITION_OPERATION_SERVICE_ID, value1);
            var value2 = new IntegerValueReceiver();
            value2.ListenTo(value1);
            var ifClause = new IfClause(value1, ConditionOperations.LessThan, value2);
            ifClause.ListenTo(value2);
            new Messenger(Lang.Res.Result).ListenTo(ifClause.Positive);
            new Messenger(Lang.Res.Result).ListenTo(ifClause.Negative);
        }

        private void DemoBoolConditionOperation(){
            var bumper = new Bumper();
            RegisterInteractiveServiceTo(BOOL_CONDITION_OPERATION_SERVICE_ID, bumper);
            var ifClause = new IfClause(bumper);
            ifClause.ListenTo(bumper);
            var value = new ValueHolder();
            var valueSetter1 = new ValueSetter(value, new DataHolder(100));
            valueSetter1.ListenTo(ifClause.Positive);
            var valueSetter2 = new ValueSetter(value, new DataHolder(200));
            valueSetter2.ListenTo(ifClause.Negative);
            var join = new Join();
            join.ListenTo(valueSetter1);
            join.ListenTo(valueSetter2);
            new Messenger(Lang.Res.Result, value).ListenTo(join);
        }

        private void StartCyclicSound(){
            var soundTone = new ValueHolder(Lang.Res.SoundTone, 100);
            RegisterInteractiveServiceTo(CYCLIC_SOUND_SERVICE_ID, soundTone);
            var ifClause = new IfClause(soundTone, ConditionOperations.LessThan, new DataHolder(200));
            ifClause.ListenTo(soundTone);
            var sound = new Sound(soundTone);
            sound.ListenTo(ifClause.Positive);
            var pause = new Pause(100);
            pause.ListenTo(sound);
            var calculate = new Calculate(soundTone, CalculationOperations.Sum, new DataHolder(20), soundTone);
            calculate.ListenTo(pause);
            ifClause.ListenTo(calculate);
            new Messenger(new DataHolder(Lang.Res.Finished)).ListenTo(ifClause.Negative);
        }

        private void DemoStartSound3Times(){
            var sound1 = new Sound(100);
            RegisterInteractiveServiceTo(SOUND_SERVICE_ID, sound1);
            var pause1 = new Pause(new ValueHolder(500));
            pause1.ListenTo(sound1);
            var tone = new ValueHolder(Lang.Res.SoundTone, 200);
            var sound2 = new Sound(tone);
            sound2.ListenTo(pause1);
            var pause2 = new Pause(2300);
            pause2.ListenTo(sound2);
            var calculate = new Calculate(tone, CalculationOperations.Sum, new ValueHolder(Lang.Res.Constant, 25), tone);
            calculate.ListenTo(pause2);
            var sound3 = new Sound(tone);
            sound3.ListenTo(calculate);
        }

        private void ControlOfDrive(){
            var integerReceiver = new IntegerValueReceiver(-1, 1);
            RegisterInteractiveServiceTo(RUN_DRIVE_SERVICE_ID, integerReceiver);
            new Messenger().ListenTo(integerReceiver);
            new Drive().ListenTo(integerReceiver);
        }

        private void DisplayReceivedValue(){
            var valueReceiverMessenger = new Messenger(_valueReceiver);
            RegisterInteractiveServiceTo(DISPLAY_VALUE_SERVICE_ID, valueReceiverMessenger);
        }

        private void ReceiveValue(){
            _valueReceiver = new ValueReceiver();
            RegisterInteractiveServiceTo(SET_VALUE_SERVICE_ID, _valueReceiver);
            new Messenger().ListenTo(_valueReceiver);
        }

        private void ClearDisplay(){
            RegisterInteractiveServiceTo(CLEAR_DISPLAY_SERVICE_ID, new ClearDisplay());
        }

        private void InteractionWithBumper(){
            var bumper = new Bumper();
            RegisterInteractiveServiceTo(BUMPER_SERVICE_ID, bumper);
            new Messenger().ListenTo(bumper);
            new LED().ListenTo(bumper);
            var valueNegator = new ValueNegator();
            valueNegator.ListenTo(bumper);
            _ledNo2Operator = new LED();
            _ledNo2Operator.ListenTo(valueNegator);
        }

        #endregion

    }
}
using System.Text;

namespace RVSLite{
    public class Lang{
        private static Lang _instance;
        public string Drive = "Drive";
        public string LED = "LED";
        public string Message = "Message";
        public string RunBackward = "Run backward";
        public string RunForward = "Run forward";
        public string Stopped = "Stopped";
        public string Messenger = "Messenger";
        public string On = "On";
        public string Off = "Off";
        public string Pressed = "Pressed";
        public string Released = "Released";
        public string Bumper = "Bumper";
        public string Undefined = "Undefined";
        public string Undefined_operator_is_called = "Undefined operator is called";
        public string Undefined_calculation_operation = "Undefined calculation operation";
        public string Undefined_condition_operation = "Undefined condition operation";
        public string Value = "Value";
        public string Empty = "Empty";
        public string Value_receiver = "Value receiver";
        public string Wait_for = "Wait for";
        public string Negate_entry_value = "Negate entry value";
        public string Negate_value = "Negate_entry_value value";
        public string Integer = "Integer";
        public string Max = "Max";
        public string Min = "Min";
        public string Clear_display = "Clear display";
        public string Sound = "Sound";
        public string Is_disconnected = "Is disconnected";
        public string Pause = "Pause";
        public string Continue = "Continue";
        public string Calculate = "Calculate";
        public string Constant = "Constant";
        public string Condition = "Condition";
        public string Lesser = "Lesser";
        public string Greater = "Greater";
        public string Signal = "Signal";
        public string Result = "Result";
        public string SetValue = "Set value";
        public string Join = "Join";
        public string Finished = "Finished";
        public string SoundTone = "Sound's tone";
        public string Check_condition = "Check condition";
        public string Data = "Data";
        public string Connection = "Connection";
        public string True = "True";
        public string False= "False";
        public string Entry_value = "Entry_value";

        public static Lang Res{
            get { return _instance ?? (_instance = new Lang()); }
            set { _instance = value; }
        }

        public static void SwitchToRu(){
            Res = new LangRu();
        }

        public virtual string InteractionHelp{
            get{
                var sb = new StringBuilder();
                sb.AppendLine("");
                sb.AppendLine("-------------------------");
                sb.AppendLine("q - Exit");
                sb.AppendLine("c - Clear");
                sb.AppendLine("1 - Bumper (press/release)");
                sb.AppendLine("2 - Set the value");
                sb.AppendLine("3 - Display the value");
                sb.AppendLine("4 - Remove the LED#2");
                sb.AppendLine("5 - Run the drive#1");
                sb.AppendLine("6 - Start sound 3 times");
                sb.AppendLine("7 - Condition operation with integer values");
                sb.AppendLine("8 - Condition operation with a boolean value");
                sb.AppendLine("9 - Start sound with a cyclic growing tone");
                sb.AppendLine("-------------------------");
                return sb.ToString();
            }
        }
    }

    public class LangRu : Lang{
        public LangRu(){
            RunForward = "Двигаться вперед";
            RunBackward = "Двигаться назад";
            Stopped = "Остановлен";
            Drive = "Мотор";
            Message = "Сообщение";
            LED = "Индикатор";
            Messenger = "Информер";
            On = "Вкл.";
            Off = "Вык.";
            Pressed = "Нажат";
            Released = "Отпущен";
            Bumper = "Бампер";
            Undefined = "Не определен";
            Undefined_operator_is_called = "Вызван не определенный оператор";
            Value = "Значение";
            Empty = "Пусто";
            Value_receiver = "Приемник значений";
            Wait_for = "Ожидание";
            Negate_value = "Инвертировать значение";
            Negate_entry_value = "Инвертировать входящие данные"; 
            Integer = "Целое";
            Max = "Макс.";
            Min = "Мин.";
            Clear_display = "Очистить экран";
            Sound = "Сигнал";
            Is_disconnected = "Отсоединен";
            Pause = "Пауза";
            Continue = "Продолжение";
            Calculate = "Вычислить";
            Undefined_calculation_operation = "Неопределенная вычислительная операция";
            Undefined_condition_operation = "Неопределенная условная операция"; 
            Constant = "Константа";
            Condition = "Условие";
            Lesser = "Меньший";
            Greater = "Больший";
            Signal = "Сигнал";
            Result = "Результат";
            SetValue = "Присвоить значение";
            Join = "Объединить";
            Finished = "Завершено";
            SoundTone = "Тон звука";
            Check_condition = "Проверить условие";
            Data = "Данные";
            Connection = "Соединение";
            True = "Да";
            False= "Нет";
            Entry_value = "Входящее значение";
        }

        public override string InteractionHelp{
            get{
                var sb = new StringBuilder();
                sb.AppendLine("");
                sb.AppendLine("-------------------------");
                sb.AppendLine("q - Выход");
                sb.AppendLine("c - Очистить");
                sb.AppendLine("1 - Бампер (нажать/отпустить)");
                sb.AppendLine("2 - Установить значение");
                sb.AppendLine("3 - Показать значение");
                sb.AppendLine("4 - Удалить Индикатор#2");
                sb.AppendLine("5 - Включить Мотор#1");
                sb.AppendLine("6 - Подать тройной сигнал");
                sb.AppendLine("7 - Условный оператор с целыми значениями");
                sb.AppendLine("8 - Условный оператор с логическим значением");
                sb.AppendLine("9 - Подать сигнал с циклически нарастающим тоном");
                sb.AppendLine("-------------------------");
                return sb.ToString();
            }
        }
    }
}
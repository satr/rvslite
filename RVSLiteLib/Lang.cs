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
        public string Undefined_operation = "Undefined operation";
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
        public string Connection_process = "Установка соединения";
        public string Disconnection_process = "Отключение соединения";
        public string True = "True";
        public string False= "False";
        public string Entry_value = "Entry_value";
        public string Require_init_value = "Require init value";
        public string Require_correct_name = "Require correct name";
        public string Name_is_already_in_use = "Name is already in use";
        public string Variable = "Variable";
        public string Do = "Do";
        public string If = "If";
        public string Port= "Port";
        public string Error = "Error";
        public string New_variable = "New variable";
        public string Name = "Name";
        public string Cancel = "Cancel";
        public string Yes = "Yes";
        public string No = "No";
        public string Correct = "Correct";
        public string Incorrect = "Incorrect";
        public string Start= "Start";
        public string Value_is_not_defined = "Value is not defined";
        public string Invalid_value = "Invalid value";
        public string Unallowed_devision_by_zero = "Unallowed devision by zero";
        public string File = "File";
        public string Exit = "Exit";
        public string Communication="Communication";
        public string Clear_terminal = "Clear terminal";
        public string Help = "Help";
        public string About = "About";
        public string Send_command="Send command";
        public string Clear = "Clear";
        public string Connect = "Connect";
        public string Disconnect = "Disonnect";
        public string Terminal_control = "Terminal control";
        public string Edit = "Edit";
        public string Terminal = "Terminal";
        public string Basic_activities = "Basic activities";
        public string Services = "Services";
        public string Clear_all = "Clear all";
        public string Milliseconds = "Milliseconds";
        public string Comment_one_second_equal_to_1000_milliseconds = "1 sec.= 1000 ms";
        public string Prompting = "Prompting";
        public string New_p = "New";


        public static Lang Res{
            get { return _instance ?? (_instance = new Lang()); }
            set { _instance = value; }
        }

        public static void SwitchToRu(){
            Res = new LangRu();
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
            Released = "Свободен";
            Bumper = "Бампер";
            Undefined = "Не определен";
            Undefined_operation = "Вызван неопределенный оператор";
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
            Undefined_operation = "Неопределенная операция";
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
            True = "Правда";
            False = "Ложь";
            Entry_value = "Входящее значение";
            Require_init_value = "Требуется начальное значение";
            Require_correct_name = "Требуется корректное имя";
            Name_is_already_in_use = "Имя уже используется";
            Variable = "Переменная";
            Do = "Делать";
            If = "Если";
            Port = "Порт";
            Error = "Ошибка";
            New_variable = "Новая переменная";
            Name = "Имя";
            Cancel = "Отменить";
            Yes = "Да";
            No = "Нет";
            Correct = "Верно";
            Incorrect = "Неверно";
            Start = "Пуск";
            Value_is_not_defined = "Значение не определено";
            Invalid_value = "Не корректное значение";
            Unallowed_devision_by_zero = "Запрещено делить на нуль";
            Connection_process = "Установка соединения";
            Disconnection_process = "Отключение соединения";
            File = "Файл";
            Exit = "Выход";
            Communication="Подключение";
            Clear_terminal = "Очистить терминал";
            Help = "Помощь";
            About = "О программе";
            Send_command="Послать комманду";
            Clear = "Очистить";
            Connect = "Подключить";
            Disconnect = "Отключить";
            Terminal_control = "Управление терминалом";
            Edit = "Редактировать";
            Terminal = "Терминал";
            Basic_activities = "Базовые активити";
            Services = "Сервисы";
            Clear_all = "Очистить все";
            Milliseconds = "Миллисекунды";
            Comment_one_second_equal_to_1000_milliseconds = "1 сек.=1000 мс";
            Prompting = "Подсказка";
            New_p = "Нов.";
       }
    }
}
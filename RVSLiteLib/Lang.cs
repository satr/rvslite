﻿using System.Text;

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
            True = "Да";
            False= "Нет";
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
        }
    }
}
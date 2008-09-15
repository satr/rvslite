namespace RVSLite.Controls{
    public interface ITriggerControl{
        event BooleanEventHandler OnStateChanged;
        bool Value { get; set; }
        string HWName { get; set; }
    }
}
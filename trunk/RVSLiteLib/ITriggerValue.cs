namespace RVSLite{
    public interface ITriggerValue{
        bool Value { get; set; }
        string HWName { get; set; }
        event TriggerEventHandler OnStateChanged;
    }
}
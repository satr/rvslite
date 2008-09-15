namespace RVSLite.Controls{
    public interface IBooleanControl{
        event PostEventHandler OnStateChanged;
        bool Value { get; set; }
        string HWName { get; set; }
    }
}
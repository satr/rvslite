namespace RVSLite{
    public interface IBooleanValue{
        object Value { get; set; }
        string Name { get; set; }
        event PostEventHandler OnStateChanged;
        void SetValue(object value);
    }
}
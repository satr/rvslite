namespace RVSLite{
    public interface IBooleanValue{
        bool Value { get; set; }
        string Name { get; set; }
        event BooleanEventHandler OnStateChanged;
        void SetValue(bool value);
    }
}
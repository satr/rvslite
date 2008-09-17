namespace RVSLite {
    public interface IValueHolder {
        object Value { set; get; }
        string Name { set; get; }
        event ValueEventHandler OnStateChanged;
        void SetValue(object value);
    }
}
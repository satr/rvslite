namespace RVSLite {
    public interface IValueHolder {
        object Value { set; get; }
        string Name { get; }
    }
}
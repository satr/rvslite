namespace RVSLite {
    public interface IService {
        object Value { set; get; }
        string ServiceName { set; get; }
        void SetValue(object value);
        event ValueEventHandler OnStateChanged;
    }
}
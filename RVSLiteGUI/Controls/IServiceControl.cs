namespace RVSLite.Controls{
    public interface IServiceControl{
        event ValueEventHandler OnStateChanged;
        object Value { get; set; }
        string ServiceName { get; set; }
    }
}
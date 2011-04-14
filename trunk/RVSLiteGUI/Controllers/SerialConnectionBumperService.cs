using RVSLite;

public class SerialConnectionBumperService : IService {
    private readonly int _number;
    private object _value;

    public SerialConnectionBumperService(string name, int number) {
        _number = number;
        ServiceName = string.Format("{0}#{1}", name, _number);
    }

    #region IService Members

    public object Value {
        get { return _value; }
        set {
            if (_value == value)
                return;
            _value = value;
            if (OnStateChanged != null)
                OnStateChanged(_value);
        }
    }

    public string ServiceName { get; set; }

    public void SetValue(object value) {
        Value = value;
    }

    public event ValueEventHandler OnStateChanged;

    #endregion
}
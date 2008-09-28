using RVSLite;
using ZigBee;
using ZigBeeLib;

public class ZegBeeBumperService : IService{
    private readonly int _number;
    private object _value;

    public ZegBeeBumperService(string name, int number, TelegesisETRX2Communicator communicator){
        _number = number;
        ServiceName = string.Format("{0}#{1}", name, _number);
        communicator.OnAnswerReceived += communicator_OnAnswerReceived;
    }

    #region IService Members

    public object Value{
        get { return _value; }
        set{
            if (_value == value)
                return;
            _value = value;
            if (OnStateChanged != null)
                OnStateChanged(_value);
        }
    }

    public string ServiceName { get; set; }

    public void SetValue(object value){
        Value = value;
    }

    public event ValueEventHandler OnStateChanged;

    #endregion

    private void communicator_OnAnswerReceived(TelegesisETRX2Communicator source){
        var sData = new TelegesisETRX2SData(source.LastReadLines);
        if (sData.IsUndefined)
            return;
        switch (_number){
            case 1:
                Value = sData.IO0;
                break;
            case 2:
                Value = sData.IO1;
                break;
            case 3:
                Value = sData.IO2;
                break;
            case 4:
                Value = sData.IO3;
                break;
        }
    }
}
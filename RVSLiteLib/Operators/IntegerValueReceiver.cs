namespace RVSLite{
    public class IntegerValueReceiver : ValueReceiver{
        private readonly int _maxValue;
        private readonly int _minValue;

        public IntegerValueReceiver() : this(int.MinValue, int.MaxValue){
        }

        public IntegerValueReceiver(int minValue, int maxValue)
            : this(Lang.Res.Integer.ToLower(), minValue, maxValue){
        }

        public IntegerValueReceiver(string title)
            : this(title, int.MinValue, int.MaxValue){
        }

        public IntegerValueReceiver(string title, int minValue, int maxValue)
            : base(title){
            _minValue = minValue;
            _maxValue = maxValue;
        }

        protected override string Range{
            get{
                string range = string.Empty;
                if (_minValue != int.MinValue)
                    range += string.Format(" {0} {1}", Lang.Res.Min.ToLower(), _minValue);
                if (_maxValue != int.MaxValue)
                    range += string.Format(" {0} {1}", Lang.Res.Max.ToLower(), _maxValue);
                return range;
            }
        }

        protected override void ReceiveValue(){
            for (;;){
                base.ReceiveValue();
                int val;
                if (!int.TryParse(Value == null ? "" : Value.ToString(), out val)
                    || val < _minValue 
                    || val > _maxValue)
                    continue;
                Value = val;
                break;
            }
        }
    }
}
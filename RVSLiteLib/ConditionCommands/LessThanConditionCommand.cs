namespace RVSLite{
    public class LessThanConditionCommand : ConditionCommandBase{
        public override bool GetConditionResult(object value1, object value2){
            return GetInnerConditionResult(value1, value2) < 0;
        }
        public override string ToString() {
            return "<";
        }
    }
}
namespace RVSLite{
    public class LessThanConditionCommand : ConditionCommandBase{
        public override object Perform(object value1, object value2){
            return GetInnerConditionResult(value1, value2) < 0;
        }
        public override string ToString() {
            return "<";
        }
    }
}
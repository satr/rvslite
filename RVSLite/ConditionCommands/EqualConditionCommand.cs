namespace RVSLite{
    public class EqualConditionCommand : ConditionCommandBase{
        public override bool GetConditionResult(IValueHolder valueHolder1, IValueHolder valueHolder2){
            return GetInnerConditionResult(valueHolder1, valueHolder2) == 0;
        }

        public override string ToString(){
            return "=";
        }
    }
}
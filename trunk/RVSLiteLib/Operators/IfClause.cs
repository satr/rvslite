using System;

namespace RVSLite{
    public enum ConditionOperations{
        LessThan,
        LessThanOrEqual,
        Equal,
        NotEqual,
        GreaterThanOrEqual,
        GreaterThan,
    }

    public class IfClause : BaseOperator{
        private ConditionCommandBase _conditionCommand;
        readonly BaseOperator _positiveResult = new BaseOperator();
        readonly BaseOperator _negativeResult = new BaseOperator();
        private ValueHolder _valueHolder;

        public IfClause(string name): base(name){
        }

        public BaseOperator Positive{
            get { return _positiveResult; }
        }

        public BaseOperator Negative{
            get{ return _negativeResult;}
        }

        public void InitBy(ConditionOperations conditionOperation, ValueHolder valueHolder){
            _conditionCommand = GetConditionCommandBy(conditionOperation);
            _valueHolder = valueHolder;
        }

        public override void Post(object value){
            DisplayThis(value);
            if (_conditionCommand.GetConditionResult(value, _valueHolder))
                Positive.Post(value);
            else
                Negative.Post(value);
        }

        private static ConditionCommandBase GetConditionCommandBy(ConditionOperations operation){
            if (operation == ConditionOperations.Equal)
                return new EqualConditionCommand();
            if (operation == ConditionOperations.GreaterThan)
                return new GreaterThanConditionCommand();
            if (operation == ConditionOperations.GreaterThanOrEqual)
                return new GreaterThanOrEqualConditionCommand();
            if (operation == ConditionOperations.LessThan)
                return new LessThanConditionCommand();
            if (operation == ConditionOperations.LessThanOrEqual)
                return new LessThanOrEqualConditionCommand();
            if (operation == ConditionOperations.NotEqual)
                return new NotEqualConditionCommand();
            throw new Exception(Lang.Res.Undefined);
        }

        public override string ToString(object value){
            return string.Format("{0}: [{1}] {2} [{3}]", Lang.Res.Check_condition, value, _conditionCommand, _valueHolder);
        }
    }
}
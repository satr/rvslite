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

    public class IfClause : OperatorBase{
        private readonly ConditionCommandBase _conditionCommand;
        readonly ValueHolder _positiveValueHolder = new ValueHolder(Lang.Res.Result, true);
        readonly ValueHolder _negativeValueHolder = new ValueHolder(Lang.Res.Result, false);

        public IfClause() : this(new NullValueHolder(), ConditionOperations.NotEqual, new NullValueHolder()){
        }

        public IfClause(ValueHolder boolValueHolder)
            : this(boolValueHolder, ConditionOperations.Equal, new DataHolder(true)){
        }

        public IfClause(ValueHolder leftValueHolder, ConditionOperations conditionOperation,
                        ValueHolder rightValueHolder){
            LeftValueHolder = leftValueHolder;
            _conditionCommand = GetConditionCommandBy(conditionOperation);
            RightValueHolder = rightValueHolder;
        }

        public ValueHolder LeftValueHolder { get; set; }

        public ValueHolder RightValueHolder { get; set; }

        public override string Name{
            get { return Lang.Res.Condition; }
        }

        public OperatorBase Positive{
            get { return _positiveValueHolder; }
        }

        public OperatorBase Negative{
            get{ return _negativeValueHolder;}
        }

        public override void Post(){
            DisplayThis();
            bool conditionResult = _conditionCommand.GetConditionResult(LeftValueHolder, RightValueHolder);
            if (conditionResult)
                Positive.Post();
            else
                Negative.Post();
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

        public override string ToString(){
            return string.Format("{0}: [{1}] {2} [{3}]", Lang.Res.Check_condition, LeftValueHolder, _conditionCommand, RightValueHolder);
        }
    }
}
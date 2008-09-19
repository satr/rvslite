using System;

namespace RVSLite{
    public enum CalculationOperations{
        Sum,
        Multiply,
        Division,
        Substraction,
    }

    public class Calculate : ValueHolder{
        private IService _valueHolder;
        private CalculationCommandBase _calculationCommand;

        public Calculate(string name): base(name){
        }

        public void SetOperandsTo(CalculationOperations operation, IService valueHolder){
            _calculationCommand = GetCalculationCommandBy(operation);
            _valueHolder = valueHolder;
        }

        public override void Post(object value){
            base.Post(_calculationCommand.Calculate(Value, _valueHolder.Value));
        }

        private static CalculationCommandBase GetCalculationCommandBy(CalculationOperations operation){
            if(operation == CalculationOperations.Sum)
                return new SumCalculationCommand();
            if(operation == CalculationOperations.Substraction)
                return new SubstractionCalculationCommand();
            if(operation == CalculationOperations.Multiply)
                return new MultiplyCalculationCommand();
            if(operation == CalculationOperations.Division)
                return new DivisionCalculationCommand();
            throw new Exception(Lang.Res.Undefined);
        }

        public override string ToString(object value){
            return string.Format("{0}: [{1}] {2} [{3}]",
                                 Name,
                                 value,
                                 _calculationCommand,
                                 _valueHolder);
        }
    }
}
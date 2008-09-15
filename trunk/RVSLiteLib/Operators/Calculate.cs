using System;

namespace RVSLite{
    public enum CalculationOperations{
        Sum,
        Multiply,
        Division,
        Substraction,
    }

    public class Calculate : ValueHolder{
        new public static readonly string OperatorName = Lang.Res.Calculate;
        private IValueHolder _leftValueHolder;
        private readonly IValueHolder _resultValueHolder;
        private IValueHolder _rightValueHolder;
        private CalculationCommandBase _calculationCommand;

        public Calculate(IValueHolder leftValueHolder, CalculationOperations operation, IValueHolder rightValueHolder){
            SetOperandsTo(leftValueHolder, operation, rightValueHolder);
            _resultValueHolder = this;
        }

        public void SetOperandsTo(IValueHolder leftValueHolder, CalculationOperations operation, IValueHolder rightValueHolder){
            _leftValueHolder = leftValueHolder;
            _calculationCommand = GetCalculationCommandBy(operation);
            _rightValueHolder = rightValueHolder;
        }

        public Calculate(IValueHolder leftValueHolder, CalculationOperations operation, IValueHolder rightValueHolder,
                         IValueHolder resultValueHolder)
            : this(leftValueHolder, operation, rightValueHolder){
            _resultValueHolder = resultValueHolder;
        }

        public override void Post(object value){
            DisplayThis();
            _resultValueHolder.Value = _calculationCommand.Calculate(_leftValueHolder, _rightValueHolder);
            FireOnPost(_resultValueHolder.Value);
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

        public override string Name{
            get { return OperatorName; }
        }

        public override string ToString(){
            return string.Format("{0}: {4} = [{1}] {2} [{3}]",
                                 Name,
                                 _leftValueHolder,
                                 _calculationCommand,
                                 _rightValueHolder,
                                 _resultValueHolder.Name);
        }
    }
}
namespace RVSLite{
    public abstract class OperatorCreatorBase{
        public abstract OperatorBase Create();

        public abstract string Name { get; }
    }

    public class MessengerOperatorCreator : OperatorCreatorBase{
        public override OperatorBase Create(){
            return new Messenger();
        }

        public override string Name{
            get { return Messenger.OperatorName; }
        }
    }

    public class ValueSetterOperatorCreator : OperatorCreatorBase{
        public override OperatorBase Create(){
            return new ValueSetter(new ValueHolder(), new ValueHolder());
        }

        public override string Name {
            get { return ValueSetter.OperatorName; }
        }
    }

    public class ValueReceiverOperatorCreator : OperatorCreatorBase{
        public override OperatorBase Create(){
            return new ValueReceiver();
        }

        public override string Name {
            get { return ValueReceiver.OperatorName; }
        }
    }

    public class ValueHolderOperatorCreator : OperatorCreatorBase{
        public override OperatorBase Create(){
            return new ValueHolder();
        }

        public override string Name {
            get { return ValueHolder.OperatorName; }
        }
    }

    public class LEDOperatorCreator : OperatorCreatorBase{
        public override OperatorBase Create(){
            return new LED();
        }

        public override string Name {
            get { return LED.OperatorName; }
        }
    }

    public class IfClauseOperatorCreator : OperatorCreatorBase{
        public override OperatorBase Create(){
            return new IfClause();
        }

        public override string Name {
            get { return IfClause.OperatorName; }
        }
    }

    public class DriveOperatorCreator : OperatorCreatorBase{
        public override OperatorBase Create(){
            return new Drive();
        }

        public override string Name {
            get { return Drive.OperatorName; }
        }
    }

    public class DataHolderOperatorCreator : OperatorCreatorBase{
        public override OperatorBase Create(){
            return new DataHolder(0);
        }

        public override string Name {
            get { return DataHolder.OperatorName; }
        }
    }

    public class CalculateOperatorCreator : OperatorCreatorBase{
        public override OperatorBase Create(){
            return new Calculate(new ValueHolder(), CalculationOperations.Sum, new ValueHolder());
        }

        public override string Name {
            get { return Calculate.OperatorName; }
        }
    }

    public class BumperOperatorCreator : OperatorCreatorBase{
        public override OperatorBase Create(){
            return new Bumper();
        }

        public override string Name {
            get { return Bumper.OperatorName; }
        }
    }
}
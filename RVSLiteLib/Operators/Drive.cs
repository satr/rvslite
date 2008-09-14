namespace RVSLite{
    public class Drive : ValueHolderContainerBase{
        private static int _instanceCounter;
        public static readonly string OperatorName = Lang.Res.Drive;
        private readonly string _name;

        public Drive()
            : this(string.Format("{0}#{1}", OperatorName, _instanceCounter++)){
        }

        public Drive(string name){
            _name = name;
        }

        private string StoppedText { get; set; }

        private string RunForwardText { set; get; }

        private string RunBackwardText { get; set; }

        public override string Name{
            get { return _name; }
        }

        public override string ToString(){
            var directionValue = ((int) _valueHolder.Value);
            string direction = directionValue < 0
                                   ? Lang.Res.RunBackward
                                   : (directionValue > 0
                                          ? Lang.Res.RunForward
                                          : Lang.Res.Stopped);
            return string.Format("{0}: {1}", Name, direction);
        }
    }
}
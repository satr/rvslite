namespace RVSLite{
    public class Sound : ValueHolderContainerBase{
        public static readonly string OperatorName = Lang.Res.Sound;

        public Sound(int tone):this(new ValueHolder(tone)){
        }

        public Sound(IValueHolder valueHolder) : base(valueHolder){
        }

        public override string Name{
            get { return OperatorName; }
            set {  }
        }
    }
}
namespace RVSLite{
    public class Sound : ValueHolderContainerBase{
        public Sound(int tone):this(new ValueHolder(tone)){
        }

        public Sound(IValueHolder valueHolder) : base(valueHolder){
        }

        public override string Name{
            get { return Lang.Res.Sound; }
        }
    }
}
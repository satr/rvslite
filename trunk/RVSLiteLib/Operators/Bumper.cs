namespace RVSLite {
    public class Bumper : TriggerValueBase {
        new public static readonly string OperatorName = Lang.Res.Value;
        private static int _instanceCounter;
        public Bumper() : this(string.Format("{0}#{1}", OperatorName, _instanceCounter++)) { }
        public Bumper(string name) : base(name, Lang.Res.Pressed, Lang.Res.Released) {}
    }
}
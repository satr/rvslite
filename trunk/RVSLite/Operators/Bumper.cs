namespace RVSLite {
    public class Bumper : TriggerValueBase {
        private static int _instanceCounter;
        public Bumper() : this(string.Format("{0}#{1}", Lang.Res.Bumper, _instanceCounter++)) { }
        public Bumper(string name) : base(name, Lang.Res.Pressed, Lang.Res.Released) {}
    }
}
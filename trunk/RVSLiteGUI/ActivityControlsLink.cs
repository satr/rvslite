namespace RVSLite{
    public class ActivityControlsLink {
        private readonly IActivityControl _sourceActivityControl;
        private readonly NeighbourDirections _sourceOutputDirection;

        public ActivityControlsLink(IActivityControl sourceActivityControl, NeighbourDirections sourceOutputDirection) {
            _sourceActivityControl = sourceActivityControl;
            _sourceOutputDirection = sourceOutputDirection;
        }

        public IActivityControl SourceActivityControl {
            get { return _sourceActivityControl; }
        }

        public NeighbourDirections Direction{
            get { return _sourceOutputDirection; }
        }
    }
}
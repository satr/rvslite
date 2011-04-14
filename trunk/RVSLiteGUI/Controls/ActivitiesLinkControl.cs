using System.Windows.Forms;

namespace RVSLite.Controls{
    public partial class ActivitiesLinkControl : UserControl{
        private const int GREATER_VALUE = 50;
        private const int LESSER_VALUE = 11;

        public ActivitiesLinkControl(ActivityControlsLink activityControlsLink){
            InitializeComponent();
            InitBy(activityControlsLink);
        }

        private void InitBy(ActivityControlsLink activityControlsLink){
            if (activityControlsLink == null)
                return;
            NeighbourDirections direction = activityControlsLink.Direction;
            pbTop.Visible = (direction == NeighbourDirections.Bottom);
            pbBottom.Visible = (direction == NeighbourDirections.Top);
            pbLeft.Visible = (direction == NeighbourDirections.Right);
            pbRight.Visible = (direction == NeighbourDirections.Left);
            if (direction == NeighbourDirections.Top
                || direction == NeighbourDirections.Bottom)
                SetHorizontalSize();
            if (direction == NeighbourDirections.Left
                || direction == NeighbourDirections.Right)
                SetVerticalSize();
        }

        private void SetHorizontalSize(){
            Width = GREATER_VALUE;
            Height = LESSER_VALUE;
        }

        private void SetVerticalSize(){
            Height = GREATER_VALUE;
            Width = LESSER_VALUE;
        }
    }
}
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RVSLite.Controls{
    public partial class DesignFieldControl : UserControl{
        public const int CellWH = 80;

        public DesignFieldControl(){
            InitializeComponent();
            DrawGrid();
            Bind();
        }

        public event PosEventHandler OnClickInPos;

        private void Bind(){
            pictureBox.MouseUp += pictureBox_MouseUp;
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e){
            if (OnClickInPos == null)
                return;
            OnClickInPos(GetPosBy(e.X), GetPosBy(e.Y));
        }

        private static int GetPosBy(int value){
            var d = (decimal) (value/CellWH);
            return (int) Math.Ceiling(d);
        }

        private void DrawGrid(){
            const int width = 1024;
            const int height = 800;
            pictureBox.Image = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(pictureBox.Image);
            for (int x = 0; x < width; x += CellWH)
                g.DrawLine(new Pen(Color.DarkGray, 1), x, 0, x, height);
            for (int y = 0; y < height; y += CellWH)
                g.DrawLine(new Pen(Color.DarkGray, 1), 0, y, width, y);
        }

        public void PlaceActivityControlAt(int column, int row, IActivityControl activityControl,
                                           ActivityControlsLink sourceActivityControlsLink){
            var control = (Control) activityControl;
            Controls.Add(control);
            control.Location = new Point(column*CellWH, row*CellWH);
            control.Size = new Size(CellWH, CellWH);
            control.BringToFront();
            InitLinkControlBy(control, sourceActivityControlsLink);
        }

        private void InitLinkControlBy(Control control, ActivityControlsLink sourceActivityControlsLink){
            if (sourceActivityControlsLink == null)
                return;
            var linkControl = new ActivitiesLinkControl(sourceActivityControlsLink);
            Controls.Add(linkControl);
            linkControl.Location = GetLinkControlLocationBy(control, sourceActivityControlsLink, linkControl);
            linkControl.BringToFront();
        }

        private static Point GetLinkControlLocationBy(Control activityControl, ActivityControlsLink activityControlsLink,
                                                      Control linkControl){
            NeighbourDirections direction = activityControlsLink.Direction;
            int x = activityControl.Location.X;
            int y = activityControl.Location.Y;
            if (direction == NeighbourDirections.Top){
                x += 5;
                y -= 5;
            }
            else if (direction == NeighbourDirections.Bottom) {
                x += 5;
                y += activityControl.Height - 5;
            }
            else if (direction == NeighbourDirections.Left){
                x -= 5;
//                y += 5;
            }
            else {//Right
                x += activityControl.Width - 5;
//                y += 5;
            }
            if (direction == NeighbourDirections.Top
                || direction == NeighbourDirections.Bottom) {
                linkControl.Width = activityControl.Width - 10;
                linkControl.Height = 10;
            }
            else{
                linkControl.Height = activityControl.Height;// -10;
                linkControl.Width = 10;
            }
            return new Point(x, y);
        }
    }
}
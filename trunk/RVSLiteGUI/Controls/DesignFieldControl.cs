using System;
using System.Drawing;
using System.Windows.Forms;

namespace RVSLite.Controls{
    public delegate void PosEventHandler(DesignFieldControl designFieldControl ,int column, int row);

    public partial class DesignFieldControl : UserControl{
        public event PosEventHandler OnClickInPos;
        public DesignFieldControl(){
            InitializeComponent();
            DrawGrid();
            Bind();
        }

        private void Bind(){
            pictureBox.MouseUp += new MouseEventHandler(pictureBox_MouseUp);
        }

        void pictureBox_MouseUp(object sender, MouseEventArgs e) {
            if (OnClickInPos == null)
                return;
            OnClickInPos(this, GetPosBy(e.X), GetPosBy(e.Y));
        }

        private static int GetPosBy(int value){
            decimal d = (decimal)(value / MainController.CellWH);
            return (int) Math.Ceiling(d);
        }

        private void DrawGrid(){
            const int width = 1024;
            const int height = 800;
            pictureBox.Image = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(pictureBox.Image);
            for (int x = 0; x < width; x += MainController.CellWH)
                g.DrawLine(new Pen(Color.DarkGray, 1), x, 0, x, height);
            for (int y = 0; y < height; y += MainController.CellWH)
                g.DrawLine(new Pen(Color.DarkGray, 1), 0, y, width, y);
        }

        public void PlaceActivityControlAt(Control control, int column, int row){
            Controls.Add(control);
            control.Location = new Point(column * MainController.CellWH, row * MainController.CellWH);
            control.Size = new Size(MainController.CellWH, MainController.CellWH);
            control.BringToFront();
        }
    }
}
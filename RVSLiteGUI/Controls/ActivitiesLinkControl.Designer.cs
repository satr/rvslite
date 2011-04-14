namespace RVSLite.Controls {
    partial class ActivitiesLinkControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivitiesLinkControl));
            this.pbLeft = new System.Windows.Forms.PictureBox();
            this.pbRight = new System.Windows.Forms.PictureBox();
            this.pbTop = new System.Windows.Forms.PictureBox();
            this.pbBottom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLeft
            // 
            this.pbLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLeft.Image = ((System.Drawing.Image)(resources.GetObject("pbLeft.Image")));
            this.pbLeft.Location = new System.Drawing.Point(0, 0);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(18, 50);
            this.pbLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLeft.TabIndex = 0;
            this.pbLeft.TabStop = false;
            this.pbLeft.Visible = false;
            // 
            // pbRight
            // 
            this.pbRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbRight.Image = ((System.Drawing.Image)(resources.GetObject("pbRight.Image")));
            this.pbRight.Location = new System.Drawing.Point(65, 0);
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(18, 50);
            this.pbRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRight.TabIndex = 0;
            this.pbRight.TabStop = false;
            this.pbRight.Visible = false;
            // 
            // pbTop
            // 
            this.pbTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbTop.Image = ((System.Drawing.Image)(resources.GetObject("pbTop.Image")));
            this.pbTop.Location = new System.Drawing.Point(18, 0);
            this.pbTop.Name = "pbTop";
            this.pbTop.Size = new System.Drawing.Size(47, 11);
            this.pbTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTop.TabIndex = 0;
            this.pbTop.TabStop = false;
            this.pbTop.Visible = false;
            // 
            // pbBottom
            // 
            this.pbBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbBottom.Image = ((System.Drawing.Image)(resources.GetObject("pbBottom.Image")));
            this.pbBottom.Location = new System.Drawing.Point(18, 39);
            this.pbBottom.Name = "pbBottom";
            this.pbBottom.Size = new System.Drawing.Size(47, 11);
            this.pbBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBottom.TabIndex = 0;
            this.pbBottom.TabStop = false;
            this.pbBottom.Visible = false;
            // 
            // ActivitiesLinkControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbBottom);
            this.Controls.Add(this.pbTop);
            this.Controls.Add(this.pbRight);
            this.Controls.Add(this.pbLeft);
            this.Name = "ActivitiesLinkControl";
            this.Size = new System.Drawing.Size(83, 50);
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBottom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLeft;
        private System.Windows.Forms.PictureBox pbRight;
        private System.Windows.Forms.PictureBox pbTop;
        private System.Windows.Forms.PictureBox pbBottom;
    }
}

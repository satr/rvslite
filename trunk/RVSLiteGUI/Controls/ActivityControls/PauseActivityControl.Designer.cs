namespace RVSLite.Controls.ActivityControls {
    partial class PauseActivityControl {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PauseActivityControl));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.cbUseConstant = new System.Windows.Forms.CheckBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.pictureBox);
            this.groupBox.Controls.Add(this.panel1);
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(150, 150);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(3, 38);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(144, 109);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtValue);
            this.panel1.Controls.Add(this.cbUseConstant);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 22);
            this.panel1.TabIndex = 8;
            // 
            // txtValue
            // 
            this.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtValue.Location = new System.Drawing.Point(15, 0);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(129, 20);
            this.txtValue.TabIndex = 5;
            // 
            // cbUseConstant
            // 
            this.cbUseConstant.AutoSize = true;
            this.cbUseConstant.Checked = true;
            this.cbUseConstant.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUseConstant.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbUseConstant.Location = new System.Drawing.Point(0, 0);
            this.cbUseConstant.Name = "cbUseConstant";
            this.cbUseConstant.Size = new System.Drawing.Size(15, 22);
            this.cbUseConstant.TabIndex = 0;
            this.cbUseConstant.UseVisualStyleBackColor = true;
            // 
            // PauseActivityControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "PauseActivityControl";
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.CheckBox cbUseConstant;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

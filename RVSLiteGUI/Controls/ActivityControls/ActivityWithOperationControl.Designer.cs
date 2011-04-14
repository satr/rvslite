namespace RVSLite.Controls.ActivityControls {
    partial class ActivityWithOperationControl {
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.variableOrDataControl = new RVSLite.Controls.VariableOrDataControl();
            this.cbOperationCommands = new System.Windows.Forms.ComboBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.pictureBox);
            this.groupBox.Controls.Add(this.variableOrDataControl);
            this.groupBox.Controls.Add(this.cbOperationCommands);
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(150, 150);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(3, 66);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(144, 81);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            // 
            // variableOrDataControl
            // 
            this.variableOrDataControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.variableOrDataControl.Location = new System.Drawing.Point(3, 37);
            this.variableOrDataControl.Name = "variableOrDataControl";
            this.variableOrDataControl.ServiceProvider = null;
            this.variableOrDataControl.Size = new System.Drawing.Size(144, 29);
            this.variableOrDataControl.TabIndex = 9;
            // 
            // cbOperationCommands
            // 
            this.cbOperationCommands.DisplayMember = "Name";
            this.cbOperationCommands.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbOperationCommands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperationCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbOperationCommands.FormattingEnabled = true;
            this.cbOperationCommands.Location = new System.Drawing.Point(3, 16);
            this.cbOperationCommands.Name = "cbOperationCommands";
            this.cbOperationCommands.Size = new System.Drawing.Size(144, 21);
            this.cbOperationCommands.TabIndex = 8;
            // 
            // ActivityWithOperationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "ActivityWithOperationControl";
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private VariableOrDataControl variableOrDataControl;
        private System.Windows.Forms.ComboBox cbOperationCommands;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

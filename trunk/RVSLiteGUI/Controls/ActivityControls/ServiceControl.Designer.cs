namespace RVSLite.Controls.ActivityControls {
    partial class ServiceControl {
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
            this.cbInstances = new System.Windows.Forms.ComboBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.cbInstances);
            this.groupBox.Controls.Add(this.lblPort);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(150, 150);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            // 
            // cbInstances
            // 
            this.cbInstances.DisplayMember = "ServiceName";
            this.cbInstances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbInstances.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInstances.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbInstances.FormattingEnabled = true;
            this.cbInstances.Location = new System.Drawing.Point(3, 29);
            this.cbInstances.Name = "cbInstances";
            this.cbInstances.Size = new System.Drawing.Size(144, 21);
            this.cbInstances.TabIndex = 4;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPort.Location = new System.Drawing.Point(3, 16);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Port";
            // 
            // ServiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "ServiceControl";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox cbInstances;
        private System.Windows.Forms.Label lblPort;
    }
}

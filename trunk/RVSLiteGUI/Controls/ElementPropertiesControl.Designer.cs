namespace RVSLite.Controls {
    partial class ElementPropertiesControl {
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
            this.pnlValue = new System.Windows.Forms.Panel();
            this.lblValue = new System.Windows.Forms.Label();
            this.pnlInstanceName = new System.Windows.Forms.Panel();
            this.pbpInstanceName = new System.Windows.Forms.Label();
            this.pnlElementName = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlValue.SuspendLayout();
            this.pnlInstanceName.SuspendLayout();
            this.pnlElementName.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlValue
            // 
            this.pnlValue.Controls.Add(this.lblValue);
            this.pnlValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlValue.Location = new System.Drawing.Point(0, 46);
            this.pnlValue.Name = "pnlValue";
            this.pnlValue.Size = new System.Drawing.Size(114, 23);
            this.pnlValue.TabIndex = 7;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblValue.Location = new System.Drawing.Point(0, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(0, 13);
            this.lblValue.TabIndex = 1;
            // 
            // pnlInstanceName
            // 
            this.pnlInstanceName.Controls.Add(this.pbpInstanceName);
            this.pnlInstanceName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInstanceName.Location = new System.Drawing.Point(0, 23);
            this.pnlInstanceName.Name = "pnlInstanceName";
            this.pnlInstanceName.Size = new System.Drawing.Size(114, 23);
            this.pnlInstanceName.TabIndex = 6;
            // 
            // pbpInstanceName
            // 
            this.pbpInstanceName.AutoSize = true;
            this.pbpInstanceName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbpInstanceName.Location = new System.Drawing.Point(0, 0);
            this.pbpInstanceName.Name = "pbpInstanceName";
            this.pbpInstanceName.Size = new System.Drawing.Size(0, 13);
            this.pbpInstanceName.TabIndex = 1;
            // 
            // pnlElementName
            // 
            this.pnlElementName.Controls.Add(this.lblName);
            this.pnlElementName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlElementName.Location = new System.Drawing.Point(0, 0);
            this.pnlElementName.Name = "pnlElementName";
            this.pnlElementName.Size = new System.Drawing.Size(114, 23);
            this.pnlElementName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 1;
            // 
            // ElementPropertiesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlValue);
            this.Controls.Add(this.pnlInstanceName);
            this.Controls.Add(this.pnlElementName);
            this.Name = "ElementPropertiesControl";
            this.Size = new System.Drawing.Size(114, 89);
            this.pnlValue.ResumeLayout(false);
            this.pnlValue.PerformLayout();
            this.pnlInstanceName.ResumeLayout(false);
            this.pnlInstanceName.PerformLayout();
            this.pnlElementName.ResumeLayout(false);
            this.pnlElementName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Panel pnlInstanceName;
        private System.Windows.Forms.Label pbpInstanceName;
        private System.Windows.Forms.Panel pnlElementName;
        private System.Windows.Forms.Label lblName;
    }
}

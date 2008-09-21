namespace RVSLite.Controls {
    partial class OperatorHolderControl {
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
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.lblOperation = new System.Windows.Forms.Label();
            this.elementPropertiesControl2 = new RVSLite.Controls.ElementPropertiesControl();
            this.elementPropertiesControl = new RVSLite.Controls.ElementPropertiesControl();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.elementPropertiesControl2);
            this.pnlCenter.Controls.Add(this.lblOperation);
            this.pnlCenter.Controls.Add(this.elementPropertiesControl);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 0);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(150, 150);
            this.pnlCenter.TabIndex = 5;
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOperation.Location = new System.Drawing.Point(0, 47);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(0, 13);
            this.lblOperation.TabIndex = 1;
            this.lblOperation.Visible = false;
            // 
            // elementPropertiesControl2
            // 
            this.elementPropertiesControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.elementPropertiesControl2.Location = new System.Drawing.Point(0, 60);
            this.elementPropertiesControl2.Name = "elementPropertiesControl2";
            this.elementPropertiesControl2.Size = new System.Drawing.Size(150, 74);
            this.elementPropertiesControl2.TabIndex = 2;
            this.elementPropertiesControl2.Visible = false;
            // 
            // elementPropertiesControl
            // 
            this.elementPropertiesControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.elementPropertiesControl.Location = new System.Drawing.Point(0, 0);
            this.elementPropertiesControl.Name = "elementPropertiesControl";
            this.elementPropertiesControl.Size = new System.Drawing.Size(150, 47);
            this.elementPropertiesControl.TabIndex = 0;
            // 
            // OperatorHolderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCenter);
            this.Name = "OperatorHolderControl";
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCenter;
        private ElementPropertiesControl elementPropertiesControl;
        private ElementPropertiesControl elementPropertiesControl2;
        private System.Windows.Forms.Label lblOperation;


    }
}

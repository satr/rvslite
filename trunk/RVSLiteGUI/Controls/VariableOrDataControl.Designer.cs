namespace RVSLite.Controls {
    partial class VariableOrDataControl {
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
            this.txtValue = new System.Windows.Forms.TextBox();
            this.cbInstances = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(3, 27);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(144, 20);
            this.txtValue.TabIndex = 8;
            // 
            // cbInstances
            // 
            this.cbInstances.DisplayMember = "Name";
            this.cbInstances.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbInstances.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInstances.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbInstances.FormattingEnabled = true;
            this.cbInstances.Location = new System.Drawing.Point(0, 0);
            this.cbInstances.Name = "cbInstances";
            this.cbInstances.Size = new System.Drawing.Size(150, 21);
            this.cbInstances.TabIndex = 7;
            // 
            // VariableOrDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.cbInstances);
            this.Name = "VariableOrDataControl";
            this.Size = new System.Drawing.Size(150, 54);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ComboBox cbInstances;
    }
}

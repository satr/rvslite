using System.Collections.Generic;

namespace RVSLite.Controls.ActivityControls {
    partial class VariableActivityControl {
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
            this.pnlNew = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.cbInstances = new System.Windows.Forms.ComboBox();
            this.groupBox.SuspendLayout();
            this.pnlNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.pnlNew);
            this.groupBox.Controls.Add(this.cbInstances);
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(150, 150);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            // 
            // pnlNew
            // 
            this.pnlNew.Controls.Add(this.btnNew);
            this.pnlNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNew.Location = new System.Drawing.Point(101, 37);
            this.pnlNew.Name = "pnlNew";
            this.pnlNew.Size = new System.Drawing.Size(46, 110);
            this.pnlNew.TabIndex = 8;
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNew.Location = new System.Drawing.Point(0, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(46, 19);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // cbInstances
            // 
            this.cbInstances.DisplayMember = "Name";
            this.cbInstances.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbInstances.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInstances.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbInstances.Location = new System.Drawing.Point(3, 16);
            this.cbInstances.Name = "cbInstances";
            this.cbInstances.Size = new System.Drawing.Size(144, 21);
            this.cbInstances.TabIndex = 7;
            // 
            // VariableActivityControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "VariableActivityControl";
            this.groupBox.ResumeLayout(false);
            this.pnlNew.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox cbInstances;
        private System.Windows.Forms.Panel pnlNew;
        private System.Windows.Forms.Button btnNew;
    }
}

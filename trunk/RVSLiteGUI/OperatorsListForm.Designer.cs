namespace RVSLite {
    partial class OperatorsListForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.cbElementCreators = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlExistObjects = new System.Windows.Forms.Panel();
            this.cbInstances = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblExistObjects = new System.Windows.Forms.Label();
            this.pnlControls.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlExistObjects.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 27);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.cbElementCreators);
            this.pnlControls.Controls.Add(this.btnAdd);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(364, 27);
            this.pnlControls.TabIndex = 3;
            // 
            // cbElementCreators
            // 
            this.cbElementCreators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbElementCreators.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbElementCreators.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbElementCreators.FormattingEnabled = true;
            this.cbElementCreators.Location = new System.Drawing.Point(75, 0);
            this.cbElementCreators.Name = "cbElementCreators";
            this.cbElementCreators.Size = new System.Drawing.Size(289, 28);
            this.cbElementCreators.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 17);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 24);
            this.panel2.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(75, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(289, 23);
            this.txtName.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 24);
            this.panel3.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(30, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(364, 10);
            this.panel4.TabIndex = 6;
            // 
            // pnlExistObjects
            // 
            this.pnlExistObjects.Controls.Add(this.cbInstances);
            this.pnlExistObjects.Controls.Add(this.panel5);
            this.pnlExistObjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExistObjects.Location = new System.Drawing.Point(0, 78);
            this.pnlExistObjects.Name = "pnlExistObjects";
            this.pnlExistObjects.Size = new System.Drawing.Size(364, 31);
            this.pnlExistObjects.TabIndex = 7;
            // 
            // cbInstances
            // 
            this.cbInstances.DisplayMember = "Name";
            this.cbInstances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbInstances.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInstances.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbInstances.FormattingEnabled = true;
            this.cbInstances.Location = new System.Drawing.Point(75, 0);
            this.cbInstances.Name = "cbInstances";
            this.cbInstances.Size = new System.Drawing.Size(289, 28);
            this.cbInstances.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblExistObjects);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(75, 31);
            this.panel5.TabIndex = 1;
            // 
            // lblExistObjects
            // 
            this.lblExistObjects.AutoSize = true;
            this.lblExistObjects.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblExistObjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExistObjects.Location = new System.Drawing.Point(38, 0);
            this.lblExistObjects.Name = "lblExistObjects";
            this.lblExistObjects.Size = new System.Drawing.Size(37, 17);
            this.lblExistObjects.TabIndex = 0;
            this.lblExistObjects.Text = "Exist";
            // 
            // OperatorsListForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 215);
            this.Controls.Add(this.pnlExistObjects);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlControls);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OperatorsListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Operators";
            this.pnlControls.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlExistObjects.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.ComboBox cbElementCreators;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlExistObjects;
        private System.Windows.Forms.ComboBox cbInstances;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblExistObjects;
        private System.Windows.Forms.TextBox txtName;

    }
}
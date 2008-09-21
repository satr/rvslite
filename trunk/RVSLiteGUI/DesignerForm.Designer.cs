namespace RVSLite {
    partial class DesignerForm {
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gbBasicActivities = new System.Windows.Forms.GroupBox();
            this.lvBasicActivities = new System.Windows.Forms.ListView();
            this.gbServices = new System.Windows.Forms.GroupBox();
            this.lvServices = new System.Windows.Forms.ListView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMainField = new System.Windows.Forms.TabPage();
            this.designFieldControl = new RVSLite.Controls.DesignFieldControl();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbBasicActivities.SuspendLayout();
            this.gbServices.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabMainField.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gbBasicActivities);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gbServices);
            this.splitContainer2.Size = new System.Drawing.Size(163, 558);
            this.splitContainer2.SplitterDistance = 313;
            this.splitContainer2.SplitterWidth = 8;
            this.splitContainer2.TabIndex = 0;
            // 
            // gbBasicActivities
            // 
            this.gbBasicActivities.Controls.Add(this.lvBasicActivities);
            this.gbBasicActivities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBasicActivities.Location = new System.Drawing.Point(0, 0);
            this.gbBasicActivities.Name = "gbBasicActivities";
            this.gbBasicActivities.Size = new System.Drawing.Size(161, 311);
            this.gbBasicActivities.TabIndex = 1;
            this.gbBasicActivities.TabStop = false;
            this.gbBasicActivities.Text = "Basic activities";
            // 
            // lvBasicActivities
            // 
            this.lvBasicActivities.AllowDrop = true;
            this.lvBasicActivities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBasicActivities.GridLines = true;
            this.lvBasicActivities.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvBasicActivities.Location = new System.Drawing.Point(3, 16);
            this.lvBasicActivities.Name = "lvBasicActivities";
            this.lvBasicActivities.Size = new System.Drawing.Size(155, 292);
            this.lvBasicActivities.TabIndex = 2;
            this.lvBasicActivities.UseCompatibleStateImageBehavior = false;
            this.lvBasicActivities.View = System.Windows.Forms.View.List;
            // 
            // gbServices
            // 
            this.gbServices.Controls.Add(this.lvServices);
            this.gbServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbServices.Location = new System.Drawing.Point(0, 0);
            this.gbServices.Name = "gbServices";
            this.gbServices.Size = new System.Drawing.Size(161, 235);
            this.gbServices.TabIndex = 2;
            this.gbServices.TabStop = false;
            this.gbServices.Text = "Services";
            // 
            // lvServices
            // 
            this.lvServices.AllowDrop = true;
            this.lvServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvServices.GridLines = true;
            this.lvServices.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvServices.Location = new System.Drawing.Point(3, 16);
            this.lvServices.Name = "lvServices";
            this.lvServices.Size = new System.Drawing.Size(155, 216);
            this.lvServices.TabIndex = 2;
            this.lvServices.UseCompatibleStateImageBehavior = false;
            this.lvServices.View = System.Windows.Forms.View.List;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1007, 558);
            this.splitContainer1.SplitterDistance = 163;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tabControl);
            this.splitContainer3.Size = new System.Drawing.Size(840, 558);
            this.splitContainer3.SplitterDistance = 673;
            this.splitContainer3.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMainField);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(673, 558);
            this.tabControl.TabIndex = 1;
            // 
            // tabMainField
            // 
            this.tabMainField.Controls.Add(this.designFieldControl);
            this.tabMainField.Location = new System.Drawing.Point(4, 22);
            this.tabMainField.Name = "tabMainField";
            this.tabMainField.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainField.Size = new System.Drawing.Size(665, 532);
            this.tabMainField.TabIndex = 1;
            this.tabMainField.Text = "Main";
            this.tabMainField.UseVisualStyleBackColor = true;
            // 
            // designFieldControl
            // 
            this.designFieldControl.AllowDrop = true;
            this.designFieldControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.designFieldControl.Location = new System.Drawing.Point(3, 3);
            this.designFieldControl.Name = "designFieldControl";
            this.designFieldControl.Size = new System.Drawing.Size(659, 526);
            this.designFieldControl.TabIndex = 0;
            // 
            // DesignerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 558);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DesignerForm";
            this.Text = "DesignerForm";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.gbBasicActivities.ResumeLayout(false);
            this.gbServices.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabMainField.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMainField;
        private RVSLite.Controls.DesignFieldControl designFieldControl;
        private System.Windows.Forms.GroupBox gbBasicActivities;
        private System.Windows.Forms.ListView lvBasicActivities;
        private System.Windows.Forms.GroupBox gbServices;
        private System.Windows.Forms.ListView lvServices;
    }
}
namespace RVSLite {
    partial class MainForm {
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
            this.pnlMainControl = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bumperControl2 = new RVSLite.Controls.BumperControl();
            this.bumperControl1 = new RVSLite.Controls.BumperControl();
            this.ledControl2 = new RVSLite.Controls.LEDControl();
            this.ledControl1 = new RVSLite.Controls.LEDControl();
            this.pnlMainControl.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainControl
            // 
            this.pnlMainControl.Controls.Add(this.bumperControl2);
            this.pnlMainControl.Controls.Add(this.bumperControl1);
            this.pnlMainControl.Controls.Add(this.ledControl2);
            this.pnlMainControl.Controls.Add(this.ledControl1);
            this.pnlMainControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMainControl.Location = new System.Drawing.Point(0, 0);
            this.pnlMainControl.Name = "pnlMainControl";
            this.pnlMainControl.Size = new System.Drawing.Size(155, 539);
            this.pnlMainControl.TabIndex = 0;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(155, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tableLayoutPanel);
            this.splitContainer.Size = new System.Drawing.Size(655, 539);
            this.splitContainer.SplitterDistance = 28;
            this.splitContainer.TabIndex = 1;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel.ColumnCount = 10;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 10;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(655, 507);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // bumperControl2
            // 
            this.bumperControl2.HWName = "Rear bumper";
            this.bumperControl2.Location = new System.Drawing.Point(4, 134);
            this.bumperControl2.Name = "bumperControl2";
            this.bumperControl2.Size = new System.Drawing.Size(98, 49);
            this.bumperControl2.TabIndex = 2;
            this.bumperControl2.Value = false;
            // 
            // bumperControl1
            // 
            this.bumperControl1.HWName = "Front bumper";
            this.bumperControl1.Location = new System.Drawing.Point(4, 13);
            this.bumperControl1.Name = "bumperControl1";
            this.bumperControl1.Size = new System.Drawing.Size(98, 49);
            this.bumperControl1.TabIndex = 2;
            this.bumperControl1.Value = false;
            // 
            // ledControl2
            // 
            this.ledControl2.HWName = "LED#2";
            this.ledControl2.Location = new System.Drawing.Point(4, 101);
            this.ledControl2.Name = "ledControl2";
            this.ledControl2.Size = new System.Drawing.Size(89, 27);
            this.ledControl2.TabIndex = 1;
            this.ledControl2.Value = false;
            // 
            // ledControl1
            // 
            this.ledControl1.HWName = "LED#1";
            this.ledControl1.Location = new System.Drawing.Point(4, 68);
            this.ledControl1.Name = "ledControl1";
            this.ledControl1.Size = new System.Drawing.Size(89, 27);
            this.ledControl1.TabIndex = 1;
            this.ledControl1.Value = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 539);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.pnlMainControl);
            this.Name = "MainForm";
            this.Text = "Robotics Visual Studio Lite";
            this.pnlMainControl.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainControl;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private RVSLite.Controls.LEDControl ledControl1;
        private RVSLite.Controls.BumperControl bumperControl1;
        private RVSLite.Controls.LEDControl ledControl2;
        private RVSLite.Controls.BumperControl bumperControl2;
    }
}


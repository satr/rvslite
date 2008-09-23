﻿namespace RVSLite {
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
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.messengerEmulatorControl1 = new RVSLite.Controls.EmulatorControls.MessengerEmulatorControl();
            this.driveControl2 = new RVSLite.Controls.DriveEmulatorControl();
            this.driveControl1 = new RVSLite.Controls.DriveEmulatorControl();
            this.bumperControl2 = new RVSLite.Controls.BumperEmulatorControl();
            this.bumperControl1 = new RVSLite.Controls.BumperEmulatorControl();
            this.ledControl2 = new RVSLite.Controls.LEDEmulatorControl();
            this.ledControl1 = new RVSLite.Controls.LEDEmulatorControl();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbBasicActivities.SuspendLayout();
            this.gbServices.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabMainField.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.SuspendLayout();
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
            this.splitContainer2.Size = new System.Drawing.Size(121, 444);
            this.splitContainer2.SplitterDistance = 249;
            this.splitContainer2.SplitterWidth = 8;
            this.splitContainer2.TabIndex = 0;
            // 
            // gbBasicActivities
            // 
            this.gbBasicActivities.Controls.Add(this.lvBasicActivities);
            this.gbBasicActivities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBasicActivities.Location = new System.Drawing.Point(0, 0);
            this.gbBasicActivities.Name = "gbBasicActivities";
            this.gbBasicActivities.Size = new System.Drawing.Size(119, 247);
            this.gbBasicActivities.TabIndex = 1;
            this.gbBasicActivities.TabStop = false;
            this.gbBasicActivities.Text = "Базовые активити";
            // 
            // lvBasicActivities
            // 
            this.lvBasicActivities.AllowDrop = true;
            this.lvBasicActivities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBasicActivities.FullRowSelect = true;
            this.lvBasicActivities.GridLines = true;
            this.lvBasicActivities.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvBasicActivities.Location = new System.Drawing.Point(3, 16);
            this.lvBasicActivities.MultiSelect = false;
            this.lvBasicActivities.Name = "lvBasicActivities";
            this.lvBasicActivities.Size = new System.Drawing.Size(113, 228);
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
            this.gbServices.Size = new System.Drawing.Size(119, 185);
            this.gbServices.TabIndex = 2;
            this.gbServices.TabStop = false;
            this.gbServices.Text = "Сервисы";
            // 
            // lvServices
            // 
            this.lvServices.AllowDrop = true;
            this.lvServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvServices.FullRowSelect = true;
            this.lvServices.GridLines = true;
            this.lvServices.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvServices.Location = new System.Drawing.Point(3, 16);
            this.lvServices.MultiSelect = false;
            this.lvServices.Name = "lvServices";
            this.lvServices.Size = new System.Drawing.Size(113, 166);
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
            this.splitContainer1.Size = new System.Drawing.Size(755, 444);
            this.splitContainer1.SplitterDistance = 121;
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
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(630, 444);
            this.splitContainer3.SplitterDistance = 448;
            this.splitContainer3.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMainField);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(448, 444);
            this.tabControl.TabIndex = 1;
            // 
            // tabMainField
            // 
            this.tabMainField.Controls.Add(this.designFieldControl);
            this.tabMainField.Location = new System.Drawing.Point(4, 22);
            this.tabMainField.Name = "tabMainField";
            this.tabMainField.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainField.Size = new System.Drawing.Size(440, 418);
            this.tabMainField.TabIndex = 1;
            this.tabMainField.Text = "Главная";
            this.tabMainField.UseVisualStyleBackColor = true;
            // 
            // designFieldControl
            // 
            this.designFieldControl.AllowDrop = true;
            this.designFieldControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.designFieldControl.Location = new System.Drawing.Point(3, 3);
            this.designFieldControl.Name = "designFieldControl";
            this.designFieldControl.Size = new System.Drawing.Size(434, 412);
            this.designFieldControl.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.messengerEmulatorControl1);
            this.splitContainer4.Panel1.Controls.Add(this.driveControl2);
            this.splitContainer4.Panel1.Controls.Add(this.driveControl1);
            this.splitContainer4.Panel1.Controls.Add(this.bumperControl2);
            this.splitContainer4.Panel1.Controls.Add(this.bumperControl1);
            this.splitContainer4.Panel1.Controls.Add(this.ledControl2);
            this.splitContainer4.Panel1.Controls.Add(this.ledControl1);
            this.splitContainer4.Size = new System.Drawing.Size(178, 444);
            this.splitContainer4.SplitterDistance = 269;
            this.splitContainer4.TabIndex = 0;
            // 
            // messengerEmulatorControl1
            // 
            this.messengerEmulatorControl1.Location = new System.Drawing.Point(3, 180);
            this.messengerEmulatorControl1.Name = "messengerEmulatorControl1";
            this.messengerEmulatorControl1.ServiceName = "Информер";
            this.messengerEmulatorControl1.Size = new System.Drawing.Size(165, 71);
            this.messengerEmulatorControl1.TabIndex = 11;
            this.messengerEmulatorControl1.Value = "";
            // 
            // driveControl2
            // 
            this.driveControl2.Location = new System.Drawing.Point(119, 45);
            this.driveControl2.Name = "driveControl2";
            this.driveControl2.ServiceName = "Правый мотор";
            this.driveControl2.Size = new System.Drawing.Size(52, 104);
            this.driveControl2.TabIndex = 10;
            this.driveControl2.Value = 0;
            // 
            // driveControl1
            // 
            this.driveControl1.Location = new System.Drawing.Point(0, 45);
            this.driveControl1.Name = "driveControl1";
            this.driveControl1.ServiceName = "Левый мотор";
            this.driveControl1.Size = new System.Drawing.Size(52, 104);
            this.driveControl1.TabIndex = 9;
            this.driveControl1.Value = 0;
            // 
            // bumperControl2
            // 
            this.bumperControl2.Location = new System.Drawing.Point(17, 157);
            this.bumperControl2.Name = "bumperControl2";
            this.bumperControl2.ServiceName = "Задний бампер";
            this.bumperControl2.Size = new System.Drawing.Size(143, 28);
            this.bumperControl2.TabIndex = 8;
            this.bumperControl2.Value = false;
            // 
            // bumperControl1
            // 
            this.bumperControl1.Location = new System.Drawing.Point(17, 10);
            this.bumperControl1.Name = "bumperControl1";
            this.bumperControl1.ServiceName = "Передний бампер";
            this.bumperControl1.Size = new System.Drawing.Size(143, 29);
            this.bumperControl1.TabIndex = 7;
            this.bumperControl1.Value = false;
            // 
            // ledControl2
            // 
            this.ledControl2.Location = new System.Drawing.Point(51, 122);
            this.ledControl2.Name = "ledControl2";
            this.ledControl2.ServiceName = "Инд#2";
            this.ledControl2.Size = new System.Drawing.Size(89, 27);
            this.ledControl2.TabIndex = 5;
            this.ledControl2.Value = false;
            // 
            // ledControl1
            // 
            this.ledControl1.Location = new System.Drawing.Point(51, 45);
            this.ledControl1.Name = "ledControl1";
            this.ledControl1.ServiceName = "Инд.#1";
            this.ledControl1.Size = new System.Drawing.Size(89, 27);
            this.ledControl1.TabIndex = 6;
            this.ledControl1.Value = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 444);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Robotics Visual Studio Lite";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.gbBasicActivities.ResumeLayout(false);
            this.gbServices.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabMainField.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer splitContainer4;
        private RVSLite.Controls.DriveEmulatorControl driveControl2;
        private RVSLite.Controls.DriveEmulatorControl driveControl1;
        private RVSLite.Controls.BumperEmulatorControl bumperControl2;
        private RVSLite.Controls.BumperEmulatorControl bumperControl1;
        private RVSLite.Controls.LEDEmulatorControl ledControl2;
        private RVSLite.Controls.LEDEmulatorControl ledControl1;
        private RVSLite.Controls.EmulatorControls.MessengerEmulatorControl messengerEmulatorControl1;
    }
}
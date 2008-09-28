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
                _terminalController.Close();
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.communicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTerminalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTopMain = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gbBasicActivities = new System.Windows.Forms.GroupBox();
            this.lvBasicActivities = new System.Windows.Forms.ListView();
            this.gbServices = new System.Windows.Forms.GroupBox();
            this.lvServices = new System.Windows.Forms.ListView();
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
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.txtTerminal = new System.Windows.Forms.TextBox();
            this.btnShowHideTerminalControls = new System.Windows.Forms.Button();
            this.pnlTerminalControls = new System.Windows.Forms.Panel();
            this.pnlMainControls = new System.Windows.Forms.Panel();
            this.txtATCommand = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSendATCommand = new System.Windows.Forms.Button();
            this.btnClearTerminal = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnShowHidePrompting = new System.Windows.Forms.Button();
            this.txtPrompting = new System.Windows.Forms.RichTextBox();
            this.menuStrip.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbBasicActivities.SuspendLayout();
            this.gbServices.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabMainField.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.pnlMainControls.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.communicationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(979, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearAllToolStripMenuItem.Text = "Clear all";
            // 
            // communicationToolStripMenuItem
            // 
            this.communicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.terminalToolStripMenuItem,
            this.clearTerminalToolStripMenuItem});
            this.communicationToolStripMenuItem.Name = "communicationToolStripMenuItem";
            this.communicationToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.communicationToolStripMenuItem.Text = "Communication";
            // 
            // terminalToolStripMenuItem
            // 
            this.terminalToolStripMenuItem.CheckOnClick = true;
            this.terminalToolStripMenuItem.Name = "terminalToolStripMenuItem";
            this.terminalToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.terminalToolStripMenuItem.Text = "Terminal";
            // 
            // clearTerminalToolStripMenuItem
            // 
            this.clearTerminalToolStripMenuItem.Name = "clearTerminalToolStripMenuItem";
            this.clearTerminalToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.clearTerminalToolStripMenuItem.Text = "Clear terminal";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // pnlTopMain
            // 
            this.pnlTopMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopMain.Location = new System.Drawing.Point(0, 24);
            this.pnlTopMain.Name = "pnlTopMain";
            this.pnlTopMain.Size = new System.Drawing.Size(979, 10);
            this.pnlTopMain.TabIndex = 1;
            this.pnlTopMain.Visible = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.splitContainer1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 34);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(979, 557);
            this.pnlMain.TabIndex = 2;
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
            this.splitContainer1.Size = new System.Drawing.Size(979, 557);
            this.splitContainer1.SplitterDistance = 155;
            this.splitContainer1.TabIndex = 2;
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
            this.splitContainer2.Size = new System.Drawing.Size(155, 557);
            this.splitContainer2.SplitterDistance = 311;
            this.splitContainer2.SplitterWidth = 8;
            this.splitContainer2.TabIndex = 0;
            // 
            // gbBasicActivities
            // 
            this.gbBasicActivities.Controls.Add(this.lvBasicActivities);
            this.gbBasicActivities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBasicActivities.Location = new System.Drawing.Point(0, 0);
            this.gbBasicActivities.Name = "gbBasicActivities";
            this.gbBasicActivities.Size = new System.Drawing.Size(153, 309);
            this.gbBasicActivities.TabIndex = 1;
            this.gbBasicActivities.TabStop = false;
            this.gbBasicActivities.Text = "Basic activity";
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
            this.lvBasicActivities.Size = new System.Drawing.Size(147, 290);
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
            this.gbServices.Size = new System.Drawing.Size(153, 236);
            this.gbServices.TabIndex = 2;
            this.gbServices.TabStop = false;
            this.gbServices.Text = "Services";
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
            this.lvServices.Size = new System.Drawing.Size(147, 217);
            this.lvServices.TabIndex = 2;
            this.lvServices.UseCompatibleStateImageBehavior = false;
            this.lvServices.View = System.Windows.Forms.View.List;
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
            this.splitContainer3.Size = new System.Drawing.Size(820, 557);
            this.splitContainer3.SplitterDistance = 517;
            this.splitContainer3.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMainField);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(517, 557);
            this.tabControl.TabIndex = 1;
            // 
            // tabMainField
            // 
            this.tabMainField.Controls.Add(this.designFieldControl);
            this.tabMainField.Location = new System.Drawing.Point(4, 22);
            this.tabMainField.Name = "tabMainField";
            this.tabMainField.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainField.Size = new System.Drawing.Size(509, 531);
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
            this.designFieldControl.Size = new System.Drawing.Size(503, 525);
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
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer4.Size = new System.Drawing.Size(299, 557);
            this.splitContainer4.SplitterDistance = 263;
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
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.txtTerminal);
            this.splitContainer5.Panel1.Controls.Add(this.btnShowHideTerminalControls);
            this.splitContainer5.Panel1.Controls.Add(this.pnlTerminalControls);
            this.splitContainer5.Panel1.Controls.Add(this.pnlMainControls);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.txtPrompting);
            this.splitContainer5.Panel2.Controls.Add(this.btnShowHidePrompting);
            this.splitContainer5.Size = new System.Drawing.Size(299, 290);
            this.splitContainer5.SplitterDistance = 197;
            this.splitContainer5.TabIndex = 0;
            // 
            // txtTerminal
            // 
            this.txtTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTerminal.Location = new System.Drawing.Point(0, 142);
            this.txtTerminal.Multiline = true;
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.ReadOnly = true;
            this.txtTerminal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTerminal.Size = new System.Drawing.Size(299, 55);
            this.txtTerminal.TabIndex = 10;
            // 
            // btnShowHideTerminalControls
            // 
            this.btnShowHideTerminalControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowHideTerminalControls.Location = new System.Drawing.Point(0, 122);
            this.btnShowHideTerminalControls.Name = "btnShowHideTerminalControls";
            this.btnShowHideTerminalControls.Size = new System.Drawing.Size(299, 20);
            this.btnShowHideTerminalControls.TabIndex = 9;
            this.btnShowHideTerminalControls.Text = "terminal controls";
            this.btnShowHideTerminalControls.UseVisualStyleBackColor = true;
            // 
            // pnlTerminalControls
            // 
            this.pnlTerminalControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTerminalControls.Location = new System.Drawing.Point(0, 43);
            this.pnlTerminalControls.Name = "pnlTerminalControls";
            this.pnlTerminalControls.Size = new System.Drawing.Size(299, 79);
            this.pnlTerminalControls.TabIndex = 8;
            this.pnlTerminalControls.Visible = false;
            // 
            // pnlMainControls
            // 
            this.pnlMainControls.Controls.Add(this.txtATCommand);
            this.pnlMainControls.Controls.Add(this.panel2);
            this.pnlMainControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainControls.Location = new System.Drawing.Point(0, 0);
            this.pnlMainControls.Name = "pnlMainControls";
            this.pnlMainControls.Size = new System.Drawing.Size(299, 43);
            this.pnlMainControls.TabIndex = 7;
            // 
            // txtATCommand
            // 
            this.txtATCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtATCommand.Location = new System.Drawing.Point(0, 23);
            this.txtATCommand.Name = "txtATCommand";
            this.txtATCommand.Size = new System.Drawing.Size(299, 20);
            this.txtATCommand.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSendATCommand);
            this.panel2.Controls.Add(this.btnClearTerminal);
            this.panel2.Controls.Add(this.btnConnect);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 23);
            this.panel2.TabIndex = 2;
            // 
            // btnSendATCommand
            // 
            this.btnSendATCommand.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSendATCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSendATCommand.Location = new System.Drawing.Point(0, 0);
            this.btnSendATCommand.Name = "btnSendATCommand";
            this.btnSendATCommand.Size = new System.Drawing.Size(149, 23);
            this.btnSendATCommand.TabIndex = 3;
            this.btnSendATCommand.Text = "Send command";
            this.btnSendATCommand.UseVisualStyleBackColor = true;
            // 
            // btnClearTerminal
            // 
            this.btnClearTerminal.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearTerminal.Location = new System.Drawing.Point(149, 0);
            this.btnClearTerminal.Name = "btnClearTerminal";
            this.btnClearTerminal.Size = new System.Drawing.Size(75, 23);
            this.btnClearTerminal.TabIndex = 2;
            this.btnClearTerminal.Text = "Clear";
            this.btnClearTerminal.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConnect.Location = new System.Drawing.Point(224, 0);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnShowHidePrompting
            // 
            this.btnShowHidePrompting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowHidePrompting.Location = new System.Drawing.Point(0, 0);
            this.btnShowHidePrompting.Name = "btnShowHidePrompting";
            this.btnShowHidePrompting.Size = new System.Drawing.Size(299, 20);
            this.btnShowHidePrompting.TabIndex = 0;
            this.btnShowHidePrompting.Text = "short help";
            this.btnShowHidePrompting.UseVisualStyleBackColor = true;
            // 
            // txtPrompting
            // 
            this.txtPrompting.BackColor = System.Drawing.SystemColors.Info;
            this.txtPrompting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrompting.Location = new System.Drawing.Point(0, 20);
            this.txtPrompting.Name = "txtPrompting";
            this.txtPrompting.ReadOnly = true;
            this.txtPrompting.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtPrompting.Size = new System.Drawing.Size(299, 69);
            this.txtPrompting.TabIndex = 1;
            this.txtPrompting.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 591);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTopMain);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Robotics Visual Studio Lite";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.gbBasicActivities.ResumeLayout(false);
            this.gbServices.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabMainField.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.ResumeLayout(false);
            this.pnlMainControls.ResumeLayout(false);
            this.pnlMainControls.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Panel pnlTopMain;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox gbBasicActivities;
        private System.Windows.Forms.ListView lvBasicActivities;
        private System.Windows.Forms.GroupBox gbServices;
        private System.Windows.Forms.ListView lvServices;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMainField;
        private RVSLite.Controls.DesignFieldControl designFieldControl;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private RVSLite.Controls.EmulatorControls.MessengerEmulatorControl messengerEmulatorControl1;
        private RVSLite.Controls.DriveEmulatorControl driveControl2;
        private RVSLite.Controls.DriveEmulatorControl driveControl1;
        private RVSLite.Controls.BumperEmulatorControl bumperControl2;
        private RVSLite.Controls.BumperEmulatorControl bumperControl1;
        private RVSLite.Controls.LEDEmulatorControl ledControl2;
        private RVSLite.Controls.LEDEmulatorControl ledControl1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem communicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearTerminalToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.TextBox txtTerminal;
        private System.Windows.Forms.Button btnShowHideTerminalControls;
        private System.Windows.Forms.Panel pnlTerminalControls;
        private System.Windows.Forms.Panel pnlMainControls;
        private System.Windows.Forms.TextBox txtATCommand;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSendATCommand;
        private System.Windows.Forms.Button btnClearTerminal;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnShowHidePrompting;
        private System.Windows.Forms.RichTextBox txtPrompting;

    }
}
namespace RVSLite {
    partial class ChartsForm {
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.numRate = new System.Windows.Forms.NumericUpDown();
            this.btnUpdateFormat = new System.Windows.Forms.Button();
            this.txtFinishSymbol = new System.Windows.Forms.TextBox();
            this.txtDevSymbol = new System.Windows.Forms.TextBox();
            this.txtStartSymbol = new System.Windows.Forms.TextBox();
            this.lblStartDevFinish = new System.Windows.Forms.Label();
            this.lstDataHolders = new System.Windows.Forms.CheckedListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numMaxParameters = new System.Windows.Forms.NumericUpDown();
            this.trkFreq = new System.Windows.Forms.TrackBar();
            this.lblMeasureFrequency = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblShift = new System.Windows.Forms.Label();
            this.trkShift = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbSendData = new System.Windows.Forms.GroupBox();
            this.numProp = new System.Windows.Forms.NumericUpDown();
            this.numIntegr = new System.Windows.Forms.NumericUpDown();
            this.numDeriv = new System.Windows.Forms.NumericUpDown();
            this.trkProp = new System.Windows.Forms.TrackBar();
            this.trkIntegr = new System.Windows.Forms.TrackBar();
            this.trkDerivative = new System.Windows.Forms.TrackBar();
            this.lblProp = new System.Windows.Forms.Label();
            this.lblIntegr = new System.Windows.Forms.Label();
            this.lblDeriv = new System.Windows.Forms.Label();
            this.chkAutoSend = new System.Windows.Forms.CheckBox();
            this.btnSendDataPID = new System.Windows.Forms.Button();
            this.txtSentData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxParameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkShift)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.gbSendData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntegr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeriv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkProp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkIntegr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkDerivative)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 600);
            this.splitContainer1.SplitterDistance = 173;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gbSendData);
            this.splitContainer2.Panel1.Controls.Add(this.numRate);
            this.splitContainer2.Panel1.Controls.Add(this.btnUpdateFormat);
            this.splitContainer2.Panel1.Controls.Add(this.txtFinishSymbol);
            this.splitContainer2.Panel1.Controls.Add(this.txtDevSymbol);
            this.splitContainer2.Panel1.Controls.Add(this.txtStartSymbol);
            this.splitContainer2.Panel1.Controls.Add(this.lblStartDevFinish);
            this.splitContainer2.Panel1.Controls.Add(this.lstDataHolders);
            this.splitContainer2.Panel1.Controls.Add(this.btnUpdate);
            this.splitContainer2.Panel1.Controls.Add(this.pnlColor);
            this.splitContainer2.Panel1.Controls.Add(this.lblColor);
            this.splitContainer2.Panel1.Controls.Add(this.txtValue);
            this.splitContainer2.Panel1.Controls.Add(this.txtName);
            this.splitContainer2.Panel1.Controls.Add(this.lblValue);
            this.splitContainer2.Panel1.Controls.Add(this.lblName);
            this.splitContainer2.Panel1.Controls.Add(this.btnStart);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.numMaxParameters);
            this.splitContainer2.Panel1.Controls.Add(this.trkFreq);
            this.splitContainer2.Panel1.Controls.Add(this.lblMeasureFrequency);
            this.splitContainer2.Panel1.Controls.Add(this.lblRate);
            this.splitContainer2.Panel1.Controls.Add(this.lblShift);
            this.splitContainer2.Panel1.Controls.Add(this.trkShift);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtSentData);
            this.splitContainer2.Size = new System.Drawing.Size(173, 600);
            this.splitContainer2.SplitterDistance = 571;
            this.splitContainer2.TabIndex = 14;
            // 
            // numRate
            // 
            this.numRate.Location = new System.Drawing.Point(45, 263);
            this.numRate.Name = "numRate";
            this.numRate.Size = new System.Drawing.Size(47, 20);
            this.numRate.TabIndex = 23;
            this.numRate.ValueChanged += new System.EventHandler(this.numRate_ValueChanged);
            // 
            // btnUpdateFormat
            // 
            this.btnUpdateFormat.Location = new System.Drawing.Point(122, 417);
            this.btnUpdateFormat.Name = "btnUpdateFormat";
            this.btnUpdateFormat.Size = new System.Drawing.Size(39, 20);
            this.btnUpdateFormat.TabIndex = 22;
            this.btnUpdateFormat.Text = "Upd";
            this.btnUpdateFormat.UseVisualStyleBackColor = true;
            this.btnUpdateFormat.Click += new System.EventHandler(this.btnUpdateFormat_Click);
            // 
            // txtFinishSymbol
            // 
            this.txtFinishSymbol.Location = new System.Drawing.Point(85, 417);
            this.txtFinishSymbol.MaxLength = 1;
            this.txtFinishSymbol.Name = "txtFinishSymbol";
            this.txtFinishSymbol.Size = new System.Drawing.Size(31, 20);
            this.txtFinishSymbol.TabIndex = 21;
            this.txtFinishSymbol.Text = "F";
            // 
            // txtDevSymbol
            // 
            this.txtDevSymbol.Location = new System.Drawing.Point(48, 417);
            this.txtDevSymbol.MaxLength = 1;
            this.txtDevSymbol.Name = "txtDevSymbol";
            this.txtDevSymbol.Size = new System.Drawing.Size(31, 20);
            this.txtDevSymbol.TabIndex = 21;
            this.txtDevSymbol.Text = ";";
            // 
            // txtStartSymbol
            // 
            this.txtStartSymbol.Location = new System.Drawing.Point(12, 417);
            this.txtStartSymbol.MaxLength = 1;
            this.txtStartSymbol.Name = "txtStartSymbol";
            this.txtStartSymbol.Size = new System.Drawing.Size(31, 20);
            this.txtStartSymbol.TabIndex = 21;
            this.txtStartSymbol.Text = "S";
            // 
            // lblStartDevFinish
            // 
            this.lblStartDevFinish.AutoSize = true;
            this.lblStartDevFinish.Location = new System.Drawing.Point(15, 401);
            this.lblStartDevFinish.Name = "lblStartDevFinish";
            this.lblStartDevFinish.Size = new System.Drawing.Size(103, 13);
            this.lblStartDevFinish.TabIndex = 20;
            this.lblStartDevFinish.Text = "Start/Devider/Finish";
            // 
            // lstDataHolders
            // 
            this.lstDataHolders.FormattingEnabled = true;
            this.lstDataHolders.Location = new System.Drawing.Point(11, 32);
            this.lstDataHolders.Name = "lstDataHolders";
            this.lstDataHolders.Size = new System.Drawing.Size(141, 169);
            this.lstDataHolders.TabIndex = 19;
            this.lstDataHolders.SelectedIndexChanged += new System.EventHandler(this.lstDataHolders_SelectedIndexChanged);
            this.lstDataHolders.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstDataHolders_ItemCheck);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(98, 263);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(54, 20);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlColor
            // 
            this.pnlColor.Location = new System.Drawing.Point(45, 236);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(28, 20);
            this.pnlColor.TabIndex = 17;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(9, 239);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 16;
            this.lblColor.Text = "Color";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(121, 236);
            this.txtValue.Name = "txtValue";
            this.txtValue.ReadOnly = true;
            this.txtValue.Size = new System.Drawing.Size(31, 20);
            this.txtValue.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(45, 210);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(107, 20);
            this.txtName.TabIndex = 15;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(84, 239);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(34, 13);
            this.lblValue.TabIndex = 14;
            this.lblValue.Text = "Value";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 213);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(11, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(141, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start/Stop";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Max.parameters";
            // 
            // numMaxParameters
            // 
            this.numMaxParameters.Location = new System.Drawing.Point(102, 369);
            this.numMaxParameters.Name = "numMaxParameters";
            this.numMaxParameters.Size = new System.Drawing.Size(36, 20);
            this.numMaxParameters.TabIndex = 11;
            this.numMaxParameters.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // trkFreq
            // 
            this.trkFreq.Location = new System.Drawing.Point(3, 344);
            this.trkFreq.Maximum = 100;
            this.trkFreq.Minimum = 5;
            this.trkFreq.Name = "trkFreq";
            this.trkFreq.Size = new System.Drawing.Size(149, 45);
            this.trkFreq.SmallChange = 5;
            this.trkFreq.TabIndex = 5;
            this.trkFreq.TickFrequency = 5;
            this.trkFreq.Value = 50;
            this.trkFreq.Scroll += new System.EventHandler(this.trkFreq_Scroll);
            // 
            // lblMeasureFrequency
            // 
            this.lblMeasureFrequency.AutoSize = true;
            this.lblMeasureFrequency.Location = new System.Drawing.Point(12, 331);
            this.lblMeasureFrequency.Name = "lblMeasureFrequency";
            this.lblMeasureFrequency.Size = new System.Drawing.Size(48, 13);
            this.lblMeasureFrequency.TabIndex = 6;
            this.lblMeasureFrequency.Text = "Measure";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(9, 263);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(30, 13);
            this.lblRate.TabIndex = 8;
            this.lblRate.Text = "Rate";
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Location = new System.Drawing.Point(9, 288);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(28, 13);
            this.lblShift.TabIndex = 8;
            this.lblShift.Text = "Shift";
            // 
            // trkShift
            // 
            this.trkShift.LargeChange = 1;
            this.trkShift.Location = new System.Drawing.Point(3, 299);
            this.trkShift.Maximum = 11;
            this.trkShift.Name = "trkShift";
            this.trkShift.Size = new System.Drawing.Size(149, 45);
            this.trkShift.TabIndex = 9;
            this.trkShift.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkShift.Scroll += new System.EventHandler(this.trkShift_Scroll);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 600);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(831, 600);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbSendData
            // 
            this.gbSendData.Controls.Add(this.label4);
            this.gbSendData.Controls.Add(this.label3);
            this.gbSendData.Controls.Add(this.label2);
            this.gbSendData.Controls.Add(this.btnSendDataPID);
            this.gbSendData.Controls.Add(this.chkAutoSend);
            this.gbSendData.Controls.Add(this.lblDeriv);
            this.gbSendData.Controls.Add(this.lblIntegr);
            this.gbSendData.Controls.Add(this.lblProp);
            this.gbSendData.Controls.Add(this.trkDerivative);
            this.gbSendData.Controls.Add(this.trkIntegr);
            this.gbSendData.Controls.Add(this.trkProp);
            this.gbSendData.Controls.Add(this.numDeriv);
            this.gbSendData.Controls.Add(this.numIntegr);
            this.gbSendData.Controls.Add(this.numProp);
            this.gbSendData.Location = new System.Drawing.Point(8, 443);
            this.gbSendData.Name = "gbSendData";
            this.gbSendData.Size = new System.Drawing.Size(152, 127);
            this.gbSendData.TabIndex = 24;
            this.gbSendData.TabStop = false;
            this.gbSendData.Text = "Send data (P/I/D)";
            // 
            // numProp
            // 
            this.numProp.Location = new System.Drawing.Point(4, 25);
            this.numProp.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numProp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numProp.Name = "numProp";
            this.numProp.Size = new System.Drawing.Size(40, 20);
            this.numProp.TabIndex = 0;
            this.numProp.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numIntegr
            // 
            this.numIntegr.DecimalPlaces = 3;
            this.numIntegr.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numIntegr.Location = new System.Drawing.Point(44, 25);
            this.numIntegr.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numIntegr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numIntegr.Name = "numIntegr";
            this.numIntegr.Size = new System.Drawing.Size(56, 20);
            this.numIntegr.TabIndex = 0;
            this.numIntegr.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // numDeriv
            // 
            this.numDeriv.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDeriv.Location = new System.Drawing.Point(99, 25);
            this.numDeriv.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numDeriv.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDeriv.Name = "numDeriv";
            this.numDeriv.Size = new System.Drawing.Size(50, 20);
            this.numDeriv.TabIndex = 0;
            this.numDeriv.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // trkProp
            // 
            this.trkProp.Location = new System.Drawing.Point(3, 45);
            this.trkProp.Minimum = 1;
            this.trkProp.Name = "trkProp";
            this.trkProp.Size = new System.Drawing.Size(107, 45);
            this.trkProp.TabIndex = 1;
            this.trkProp.Value = 1;
            this.trkProp.Scroll += new System.EventHandler(this.trkProp_Scroll);
            // 
            // trkIntegr
            // 
            this.trkIntegr.Location = new System.Drawing.Point(3, 65);
            this.trkIntegr.Minimum = 1;
            this.trkIntegr.Name = "trkIntegr";
            this.trkIntegr.Size = new System.Drawing.Size(107, 45);
            this.trkIntegr.TabIndex = 1;
            this.trkIntegr.Value = 1;
            this.trkIntegr.Scroll += new System.EventHandler(this.trkIntegr_Scroll);
            // 
            // trkDerivative
            // 
            this.trkDerivative.Location = new System.Drawing.Point(3, 85);
            this.trkDerivative.Minimum = 1;
            this.trkDerivative.Name = "trkDerivative";
            this.trkDerivative.Size = new System.Drawing.Size(107, 45);
            this.trkDerivative.TabIndex = 1;
            this.trkDerivative.Value = 1;
            this.trkDerivative.Scroll += new System.EventHandler(this.trkDerivative_Scroll);
            // 
            // lblProp
            // 
            this.lblProp.AutoSize = true;
            this.lblProp.Location = new System.Drawing.Point(106, 49);
            this.lblProp.Name = "lblProp";
            this.lblProp.Size = new System.Drawing.Size(29, 13);
            this.lblProp.TabIndex = 2;
            this.lblProp.Text = "Prop";
            // 
            // lblIntegr
            // 
            this.lblIntegr.AutoSize = true;
            this.lblIntegr.Location = new System.Drawing.Point(106, 68);
            this.lblIntegr.Name = "lblIntegr";
            this.lblIntegr.Size = new System.Drawing.Size(34, 13);
            this.lblIntegr.TabIndex = 2;
            this.lblIntegr.Text = "Integr";
            // 
            // lblDeriv
            // 
            this.lblDeriv.AutoSize = true;
            this.lblDeriv.Location = new System.Drawing.Point(107, 88);
            this.lblDeriv.Name = "lblDeriv";
            this.lblDeriv.Size = new System.Drawing.Size(32, 13);
            this.lblDeriv.TabIndex = 2;
            this.lblDeriv.Text = "Deriv";
            // 
            // chkAutoSend
            // 
            this.chkAutoSend.AutoSize = true;
            this.chkAutoSend.Location = new System.Drawing.Point(10, 110);
            this.chkAutoSend.Name = "chkAutoSend";
            this.chkAutoSend.Size = new System.Drawing.Size(74, 17);
            this.chkAutoSend.TabIndex = 3;
            this.chkAutoSend.Text = "Auto send";
            this.chkAutoSend.UseVisualStyleBackColor = true;
            // 
            // btnSendDataPID
            // 
            this.btnSendDataPID.Location = new System.Drawing.Point(104, 104);
            this.btnSendDataPID.Name = "btnSendDataPID";
            this.btnSendDataPID.Size = new System.Drawing.Size(42, 21);
            this.btnSendDataPID.TabIndex = 4;
            this.btnSendDataPID.Text = "Send";
            this.btnSendDataPID.UseVisualStyleBackColor = true;
            this.btnSendDataPID.Click += new System.EventHandler(this.btnSendDataPID_Click);
            // 
            // txtSentData
            // 
            this.txtSentData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSentData.Location = new System.Drawing.Point(0, 0);
            this.txtSentData.Multiline = true;
            this.txtSentData.Name = "txtSentData";
            this.txtSentData.ReadOnly = true;
            this.txtSentData.Size = new System.Drawing.Size(173, 25);
            this.txtSentData.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "max P";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "max I";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "max D";
            // 
            // ChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 600);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChartsForm";
            this.Text = "Charts";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxParameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkShift)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.gbSendData.ResumeLayout(false);
            this.gbSendData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntegr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeriv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkProp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkIntegr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkDerivative)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trkFreq;
        private System.Windows.Forms.Label lblMeasureFrequency;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TrackBar trkShift;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numMaxParameters;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckedListBox lstDataHolders;
        private System.Windows.Forms.TextBox txtFinishSymbol;
        private System.Windows.Forms.TextBox txtDevSymbol;
        private System.Windows.Forms.TextBox txtStartSymbol;
        private System.Windows.Forms.Label lblStartDevFinish;
        private System.Windows.Forms.Button btnUpdateFormat;
        private System.Windows.Forms.NumericUpDown numRate;
        private System.Windows.Forms.GroupBox gbSendData;
        private System.Windows.Forms.TrackBar trkDerivative;
        private System.Windows.Forms.TrackBar trkIntegr;
        private System.Windows.Forms.TrackBar trkProp;
        private System.Windows.Forms.NumericUpDown numDeriv;
        private System.Windows.Forms.NumericUpDown numIntegr;
        private System.Windows.Forms.NumericUpDown numProp;
        private System.Windows.Forms.Label lblDeriv;
        private System.Windows.Forms.Label lblIntegr;
        private System.Windows.Forms.Label lblProp;
        private System.Windows.Forms.CheckBox chkAutoSend;
        private System.Windows.Forms.Button btnSendDataPID;
        private System.Windows.Forms.TextBox txtSentData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
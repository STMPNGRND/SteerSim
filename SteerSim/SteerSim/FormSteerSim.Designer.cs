﻿namespace SteerSim
{
    partial class FormSteerSim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtNMEA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudHz = new System.Windows.Forms.NumericUpDown();
            this.lblHeading = new System.Windows.Forms.Label();
            this.tbarStepDistance = new System.Windows.Forms.TrackBar();
            this.lblStep = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAltitude = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.chkGGA = new System.Windows.Forms.CheckBox();
            this.chkVTG = new System.Windows.Forms.CheckBox();
            this.chkRMC = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.tboxIP = new System.Windows.Forms.TextBox();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.btnCloseSerial = new System.Windows.Forms.Button();
            this.cboxPort = new System.Windows.Forms.ComboBox();
            this.cboxBaud = new System.Windows.Forms.ComboBox();
            this.btnOpenSerial = new System.Windows.Forms.Button();
            this.tbarSteerAngle = new System.Windows.Forms.TrackBar();
            this.lblSteerAngle = new System.Windows.Forms.Label();
            this.btnTbarReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudCountsPerDegree = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarStepDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSteerAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountsPerDegree)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtNMEA
            // 
            this.txtNMEA.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNMEA.Location = new System.Drawing.Point(6, 9);
            this.txtNMEA.Multiline = true;
            this.txtNMEA.Name = "txtNMEA";
            this.txtNMEA.Size = new System.Drawing.Size(475, 93);
            this.txtNMEA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "M/sec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hz";
            // 
            // nudHz
            // 
            this.nudHz.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHz.Location = new System.Drawing.Point(272, 162);
            this.nudHz.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudHz.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHz.Name = "nudHz";
            this.nudHz.Size = new System.Drawing.Size(60, 40);
            this.nudHz.TabIndex = 4;
            this.nudHz.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudHz.ValueChanged += new System.EventHandler(this.nudHz_ValueChanged);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(305, 294);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(66, 36);
            this.lblHeading.TabIndex = 9;
            this.lblHeading.Text = "180";
            // 
            // tbarStepDistance
            // 
            this.tbarStepDistance.LargeChange = 10;
            this.tbarStepDistance.Location = new System.Drawing.Point(10, 285);
            this.tbarStepDistance.Maximum = 100;
            this.tbarStepDistance.Name = "tbarStepDistance";
            this.tbarStepDistance.Size = new System.Drawing.Size(283, 45);
            this.tbarStepDistance.TabIndex = 18;
            this.tbarStepDistance.TickFrequency = 10;
            this.tbarStepDistance.Value = 20;
            this.tbarStepDistance.Scroll += new System.EventHandler(this.tbarStepDistance_Scroll);
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep.Location = new System.Drawing.Point(116, 260);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(20, 24);
            this.lblStep.TabIndex = 19;
            this.lblStep.Text = "1";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(214, 260);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(20, 24);
            this.lblSpeed.TabIndex = 54;
            this.lblSpeed.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "kmh";
            // 
            // nudAltitude
            // 
            this.nudAltitude.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAltitude.Location = new System.Drawing.Point(375, 162);
            this.nudAltitude.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudAltitude.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAltitude.Name = "nudAltitude";
            this.nudAltitude.Size = new System.Drawing.Size(94, 40);
            this.nudAltitude.TabIndex = 56;
            this.nudAltitude.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAltitude.ValueChanged += new System.EventHandler(this.nudAltitude_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(381, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 57;
            this.label6.Text = "Altitude";
            // 
            // chkGGA
            // 
            this.chkGGA.AutoSize = true;
            this.chkGGA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGGA.Location = new System.Drawing.Point(19, 154);
            this.chkGGA.Name = "chkGGA";
            this.chkGGA.Size = new System.Drawing.Size(65, 24);
            this.chkGGA.TabIndex = 58;
            this.chkGGA.Text = "GGA";
            this.chkGGA.UseVisualStyleBackColor = true;
            // 
            // chkVTG
            // 
            this.chkVTG.AutoSize = true;
            this.chkVTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVTG.Location = new System.Drawing.Point(19, 183);
            this.chkVTG.Name = "chkVTG";
            this.chkVTG.Size = new System.Drawing.Size(61, 24);
            this.chkVTG.TabIndex = 59;
            this.chkVTG.Text = "VTG";
            this.chkVTG.UseVisualStyleBackColor = true;
            // 
            // chkRMC
            // 
            this.chkRMC.AutoSize = true;
            this.chkRMC.Checked = true;
            this.chkRMC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRMC.Location = new System.Drawing.Point(19, 212);
            this.chkRMC.Name = "chkRMC";
            this.chkRMC.Size = new System.Drawing.Size(64, 24);
            this.chkRMC.TabIndex = 60;
            this.chkRMC.Text = "RMC";
            this.chkRMC.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(310, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 62;
            this.label8.Text = "Heading";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(375, 223);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 32);
            this.btnReset.TabIndex = 63;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tboxIP
            // 
            this.tboxIP.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxIP.Location = new System.Drawing.Point(129, 162);
            this.tboxIP.Name = "tboxIP";
            this.tboxIP.Size = new System.Drawing.Size(126, 32);
            this.tboxIP.TabIndex = 65;
            this.tboxIP.Text = "127.0.0.1";
            // 
            // nudPort
            // 
            this.nudPort.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPort.Location = new System.Drawing.Point(130, 204);
            this.nudPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudPort.Minimum = new decimal(new int[] {
            1025,
            0,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(96, 32);
            this.nudPort.TabIndex = 66;
            this.nudPort.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(92, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 16);
            this.label9.TabIndex = 67;
            this.label9.Text = "Port";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(103, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 16);
            this.label10.TabIndex = 68;
            this.label10.Text = "IP";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(254, 223);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(87, 32);
            this.buttonConnect.TabIndex = 64;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // btnCloseSerial
            // 
            this.btnCloseSerial.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCloseSerial.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCloseSerial.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSerial.Location = new System.Drawing.Point(369, 108);
            this.btnCloseSerial.Name = "btnCloseSerial";
            this.btnCloseSerial.Size = new System.Drawing.Size(95, 29);
            this.btnCloseSerial.TabIndex = 72;
            this.btnCloseSerial.Text = "Close";
            this.btnCloseSerial.UseVisualStyleBackColor = false;
            this.btnCloseSerial.Click += new System.EventHandler(this.btnCloseSerial_Click_1);
            // 
            // cboxPort
            // 
            this.cboxPort.AllowDrop = true;
            this.cboxPort.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboxPort.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboxPort.FormattingEnabled = true;
            this.cboxPort.Location = new System.Drawing.Point(19, 109);
            this.cboxPort.Name = "cboxPort";
            this.cboxPort.Size = new System.Drawing.Size(96, 28);
            this.cboxPort.TabIndex = 70;
            this.cboxPort.Text = "Port";
            this.cboxPort.Leave += new System.EventHandler(this.cboxPort_Leave_1);
            // 
            // cboxBaud
            // 
            this.cboxBaud.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboxBaud.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxBaud.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboxBaud.FormattingEnabled = true;
            this.cboxBaud.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cboxBaud.Location = new System.Drawing.Point(129, 109);
            this.cboxBaud.Name = "cboxBaud";
            this.cboxBaud.Size = new System.Drawing.Size(96, 28);
            this.cboxBaud.TabIndex = 71;
            this.cboxBaud.Text = "Baud";
            this.cboxBaud.Leave += new System.EventHandler(this.cboxBaud_Leave_1);
            // 
            // btnOpenSerial
            // 
            this.btnOpenSerial.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOpenSerial.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenSerial.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSerial.Location = new System.Drawing.Point(246, 109);
            this.btnOpenSerial.Name = "btnOpenSerial";
            this.btnOpenSerial.Size = new System.Drawing.Size(95, 28);
            this.btnOpenSerial.TabIndex = 73;
            this.btnOpenSerial.Text = "Open";
            this.btnOpenSerial.UseVisualStyleBackColor = false;
            this.btnOpenSerial.Click += new System.EventHandler(this.btnOpenSerial_Click_1);
            // 
            // tbarSteerAngle
            // 
            this.tbarSteerAngle.LargeChange = 10;
            this.tbarSteerAngle.Location = new System.Drawing.Point(6, 360);
            this.tbarSteerAngle.Maximum = 300;
            this.tbarSteerAngle.Minimum = -300;
            this.tbarSteerAngle.Name = "tbarSteerAngle";
            this.tbarSteerAngle.RightToLeftLayout = true;
            this.tbarSteerAngle.Size = new System.Drawing.Size(363, 45);
            this.tbarSteerAngle.TabIndex = 75;
            this.tbarSteerAngle.TickFrequency = 30;
            this.tbarSteerAngle.Scroll += new System.EventHandler(this.tbarSteerAngle_Scroll);
            // 
            // lblSteerAngle
            // 
            this.lblSteerAngle.AutoSize = true;
            this.lblSteerAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteerAngle.Location = new System.Drawing.Point(173, 321);
            this.lblSteerAngle.Name = "lblSteerAngle";
            this.lblSteerAngle.Size = new System.Drawing.Size(32, 36);
            this.lblSteerAngle.TabIndex = 76;
            this.lblSteerAngle.Text = "0";
            // 
            // btnTbarReset
            // 
            this.btnTbarReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTbarReset.Location = new System.Drawing.Point(375, 360);
            this.btnTbarReset.Name = "btnTbarReset";
            this.btnTbarReset.Size = new System.Drawing.Size(69, 32);
            this.btnTbarReset.TabIndex = 77;
            this.btnTbarReset.Text = ">0<";
            this.btnTbarReset.UseVisualStyleBackColor = true;
            this.btnTbarReset.Click += new System.EventHandler(this.btnTbarReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 78;
            this.label4.Text = "Steer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 79;
            this.label5.Text = "|";
            // 
            // nudCountsPerDegree
            // 
            this.nudCountsPerDegree.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCountsPerDegree.Location = new System.Drawing.Point(394, 294);
            this.nudCountsPerDegree.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.nudCountsPerDegree.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCountsPerDegree.Name = "nudCountsPerDegree";
            this.nudCountsPerDegree.Size = new System.Drawing.Size(75, 40);
            this.nudCountsPerDegree.TabIndex = 80;
            this.nudCountsPerDegree.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudCountsPerDegree.ValueChanged += new System.EventHandler(this.nudCountsPerDegree_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(389, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 81;
            this.label7.Text = "Counts / Deg";
            // 
            // FormSteerSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 419);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudCountsPerDegree);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTbarReset);
            this.Controls.Add(this.lblSteerAngle);
            this.Controls.Add(this.tbarSteerAngle);
            this.Controls.Add(this.btnCloseSerial);
            this.Controls.Add(this.cboxPort);
            this.Controls.Add(this.cboxBaud);
            this.Controls.Add(this.btnOpenSerial);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.nudHz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudPort);
            this.Controls.Add(this.tboxIP);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.chkRMC);
            this.Controls.Add(this.chkVTG);
            this.Controls.Add(this.chkGGA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudAltitude);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblStep);
            this.Controls.Add(this.tbarStepDistance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNMEA);
            this.Name = "FormSteerSim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPS Simulator";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSim_FormClosing);
            this.Load += new System.EventHandler(this.FormSim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarStepDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSteerAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountsPerDegree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtNMEA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudHz;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.TrackBar tbarStepDistance;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAltitude;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkGGA;
        private System.Windows.Forms.CheckBox chkVTG;
        private System.Windows.Forms.CheckBox chkRMC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tboxIP;
        private System.Windows.Forms.NumericUpDown nudPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button btnCloseSerial;
        private System.Windows.Forms.ComboBox cboxPort;
        private System.Windows.Forms.ComboBox cboxBaud;
        private System.Windows.Forms.Button btnOpenSerial;
        private System.Windows.Forms.TrackBar tbarSteerAngle;
        private System.Windows.Forms.Label lblSteerAngle;
        private System.Windows.Forms.Button btnTbarReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudCountsPerDegree;
        private System.Windows.Forms.Label label7;
    }
}


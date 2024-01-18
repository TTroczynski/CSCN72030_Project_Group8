using Microsoft.Win32;
using System;
using System.Timers;

namespace MainProgram
{
    partial class TankGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TankGui));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ammonia_lbl = new System.Windows.Forms.Label();
            this.Nitrite_lbl = new System.Windows.Forms.Label();
            this.Nitrate_lbl = new System.Windows.Forms.Label();
            this.pb_NitriteIcon = new System.Windows.Forms.PictureBox();
            this.pb_AmmoniaIcon = new System.Windows.Forms.PictureBox();
            this.pb_SalinityIcon = new System.Windows.Forms.PictureBox();
            this.pb_NitrateIcon = new System.Windows.Forms.PictureBox();
            this.pb_PhIcon = new System.Windows.Forms.PictureBox();
            this.pb_HeaterIcon = new System.Windows.Forms.PictureBox();
            this.pb_PumpIcon = new System.Windows.Forms.PictureBox();
            this.pb_HardnessIcon = new System.Windows.Forms.PictureBox();
            this.sal_max = new System.Windows.Forms.Label();
            this.htr_max = new System.Windows.Forms.Label();
            this.hrd_max = new System.Windows.Forms.Label();
            this.amm_max = new System.Windows.Forms.Label();
            this.nitrite_max = new System.Windows.Forms.Label();
            this.nitrate_max = new System.Windows.Forms.Label();
            this.nitrate_min = new System.Windows.Forms.Label();
            this.nitrite_min = new System.Windows.Forms.Label();
            this.amm_min = new System.Windows.Forms.Label();
            this.htr_min = new System.Windows.Forms.Label();
            this.sal_min = new System.Windows.Forms.Label();
            this.ph_max = new System.Windows.Forms.Label();
            this.ph_min = new System.Windows.Forms.Label();
            this.sal_label = new System.Windows.Forms.Label();
            this.ph_label = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_Salinity_Value = new System.Windows.Forms.Label();
            this.lbl_Ammonia_Value = new System.Windows.Forms.Label();
            this.lbl_Nitrite_Value = new System.Windows.Forms.Label();
            this.lbl_Nitrate_Value = new System.Windows.Forms.Label();
            this.lbl_Acidity_Value = new System.Windows.Forms.Label();
            this.lbl_Heater_Value = new System.Windows.Forms.Label();
            this.lbl_Pump_Value = new System.Windows.Forms.Label();
            this.lbl_Hardness_Value = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.acid_G_border = new System.Windows.Forms.PictureBox();
            this.acid_R_border = new System.Windows.Forms.PictureBox();
            this.sal_G_border = new System.Windows.Forms.PictureBox();
            this.sal_R_border = new System.Windows.Forms.PictureBox();
            this.htr_G_border = new System.Windows.Forms.PictureBox();
            this.htr_R_border = new System.Windows.Forms.PictureBox();
            this.hrd_G_border = new System.Windows.Forms.PictureBox();
            this.pump_G_border = new System.Windows.Forms.PictureBox();
            this.pump_R_border = new System.Windows.Forms.PictureBox();
            this.hrd_R_border = new System.Windows.Forms.PictureBox();
            this.amm_G_border = new System.Windows.Forms.PictureBox();
            this.amm_R_border = new System.Windows.Forms.PictureBox();
            this.nitrite_G_border = new System.Windows.Forms.PictureBox();
            this.nitrite_R_border = new System.Windows.Forms.PictureBox();
            this.nitrate_G_border = new System.Windows.Forms.PictureBox();
            this.nitrate_R_border = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Auto = new System.Windows.Forms.Button();
            this.btn_Manual = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_Alarms = new System.Windows.Forms.Button();
            this.pnl_FaultBanner = new System.Windows.Forms.Panel();
            this.lbl_Alarms = new System.Windows.Forms.Label();
            this.timerReadings = new System.Timers.Timer();
            this.timerMessages = new System.Timers.Timer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NitriteIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AmmoniaIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SalinityIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NitrateIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PhIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_HeaterIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PumpIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_HardnessIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acid_G_border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acid_R_border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sal_G_border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sal_R_border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.htr_G_border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.htr_R_border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrd_G_border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pump_G_border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pump_R_border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrd_R_border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amm_G_border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amm_R_border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nitrite_G_border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nitrite_R_border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nitrate_G_border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nitrate_R_border)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnl_FaultBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerReadings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::MainProgram.Properties.Resources.tank_concept3;
            this.panel1.Controls.Add(this.Ammonia_lbl);
            this.panel1.Controls.Add(this.Nitrite_lbl);
            this.panel1.Controls.Add(this.Nitrate_lbl);
            this.panel1.Controls.Add(this.pb_NitriteIcon);
            this.panel1.Controls.Add(this.pb_AmmoniaIcon);
            this.panel1.Controls.Add(this.pb_SalinityIcon);
            this.panel1.Controls.Add(this.pb_NitrateIcon);
            this.panel1.Controls.Add(this.pb_PhIcon);
            this.panel1.Controls.Add(this.pb_HeaterIcon);
            this.panel1.Controls.Add(this.pb_PumpIcon);
            this.panel1.Controls.Add(this.pb_HardnessIcon);
            this.panel1.Controls.Add(this.sal_max);
            this.panel1.Controls.Add(this.htr_max);
            this.panel1.Controls.Add(this.hrd_max);
            this.panel1.Controls.Add(this.amm_max);
            this.panel1.Controls.Add(this.nitrite_max);
            this.panel1.Controls.Add(this.nitrate_max);
            this.panel1.Controls.Add(this.nitrate_min);
            this.panel1.Controls.Add(this.nitrite_min);
            this.panel1.Controls.Add(this.amm_min);
            this.panel1.Controls.Add(this.htr_min);
            this.panel1.Controls.Add(this.sal_min);
            this.panel1.Controls.Add(this.ph_max);
            this.panel1.Controls.Add(this.ph_min);
            this.panel1.Controls.Add(this.sal_label);
            this.panel1.Controls.Add(this.ph_label);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbl_Salinity_Value);
            this.panel1.Controls.Add(this.lbl_Ammonia_Value);
            this.panel1.Controls.Add(this.lbl_Nitrite_Value);
            this.panel1.Controls.Add(this.lbl_Nitrate_Value);
            this.panel1.Controls.Add(this.lbl_Acidity_Value);
            this.panel1.Controls.Add(this.lbl_Heater_Value);
            this.panel1.Controls.Add(this.lbl_Pump_Value);
            this.panel1.Controls.Add(this.lbl_Hardness_Value);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.acid_G_border);
            this.panel1.Controls.Add(this.acid_R_border);
            this.panel1.Controls.Add(this.sal_G_border);
            this.panel1.Controls.Add(this.sal_R_border);
            this.panel1.Controls.Add(this.htr_G_border);
            this.panel1.Controls.Add(this.htr_R_border);
            this.panel1.Controls.Add(this.hrd_G_border);
            this.panel1.Controls.Add(this.pump_G_border);
            this.panel1.Controls.Add(this.pump_R_border);
            this.panel1.Controls.Add(this.hrd_R_border);
            this.panel1.Controls.Add(this.amm_G_border);
            this.panel1.Controls.Add(this.amm_R_border);
            this.panel1.Controls.Add(this.nitrite_G_border);
            this.panel1.Controls.Add(this.nitrite_R_border);
            this.panel1.Controls.Add(this.nitrate_G_border);
            this.panel1.Controls.Add(this.nitrate_R_border);
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 479);
            this.panel1.TabIndex = 0;
            // 
            // Ammonia_lbl
            // 
            this.Ammonia_lbl.AutoSize = true;
            this.Ammonia_lbl.Location = new System.Drawing.Point(800, 173);
            this.Ammonia_lbl.Name = "Ammonia_lbl";
            this.Ammonia_lbl.Size = new System.Drawing.Size(41, 13);
            this.Ammonia_lbl.TabIndex = 62;
            this.Ammonia_lbl.Text = "label19";
            // 
            // Nitrite_lbl
            // 
            this.Nitrite_lbl.AutoSize = true;
            this.Nitrite_lbl.Location = new System.Drawing.Point(809, 323);
            this.Nitrite_lbl.Name = "Nitrite_lbl";
            this.Nitrite_lbl.Size = new System.Drawing.Size(41, 13);
            this.Nitrite_lbl.TabIndex = 61;
            this.Nitrite_lbl.Text = "label18";
            // 
            // Nitrate_lbl
            // 
            this.Nitrate_lbl.AutoSize = true;
            this.Nitrate_lbl.Location = new System.Drawing.Point(605, 330);
            this.Nitrate_lbl.Name = "Nitrate_lbl";
            this.Nitrate_lbl.Size = new System.Drawing.Size(41, 13);
            this.Nitrate_lbl.TabIndex = 60;
            this.Nitrate_lbl.Text = "label17";
            // 
            // pb_NitriteIcon
            // 
            this.pb_NitriteIcon.Location = new System.Drawing.Point(746, 364);
            this.pb_NitriteIcon.Name = "pb_NitriteIcon";
            this.pb_NitriteIcon.Size = new System.Drawing.Size(85, 85);
            this.pb_NitriteIcon.TabIndex = 59;
            this.pb_NitriteIcon.TabStop = false;
            // 
            // pb_AmmoniaIcon
            // 
            this.pb_AmmoniaIcon.Location = new System.Drawing.Point(746, 213);
            this.pb_AmmoniaIcon.Name = "pb_AmmoniaIcon";
            this.pb_AmmoniaIcon.Size = new System.Drawing.Size(85, 85);
            this.pb_AmmoniaIcon.TabIndex = 58;
            this.pb_AmmoniaIcon.TabStop = false;
            // 
            // pb_SalinityIcon
            // 
            this.pb_SalinityIcon.Location = new System.Drawing.Point(746, 48);
            this.pb_SalinityIcon.Name = "pb_SalinityIcon";
            this.pb_SalinityIcon.Size = new System.Drawing.Size(85, 85);
            this.pb_SalinityIcon.TabIndex = 57;
            this.pb_SalinityIcon.TabStop = false;
            // 
            // pb_NitrateIcon
            // 
            this.pb_NitrateIcon.Location = new System.Drawing.Point(539, 368);
            this.pb_NitrateIcon.Name = "pb_NitrateIcon";
            this.pb_NitrateIcon.Size = new System.Drawing.Size(85, 85);
            this.pb_NitrateIcon.TabIndex = 56;
            this.pb_NitrateIcon.TabStop = false;
            // 
            // pb_PhIcon
            // 
            this.pb_PhIcon.Location = new System.Drawing.Point(227, 368);
            this.pb_PhIcon.Name = "pb_PhIcon";
            this.pb_PhIcon.Size = new System.Drawing.Size(85, 85);
            this.pb_PhIcon.TabIndex = 55;
            this.pb_PhIcon.TabStop = false;
            // 
            // pb_HeaterIcon
            // 
            this.pb_HeaterIcon.Location = new System.Drawing.Point(32, 355);
            this.pb_HeaterIcon.Name = "pb_HeaterIcon";
            this.pb_HeaterIcon.Size = new System.Drawing.Size(85, 85);
            this.pb_HeaterIcon.TabIndex = 54;
            this.pb_HeaterIcon.TabStop = false;
            // 
            // pb_PumpIcon
            // 
            this.pb_PumpIcon.Location = new System.Drawing.Point(32, 212);
            this.pb_PumpIcon.Name = "pb_PumpIcon";
            this.pb_PumpIcon.Size = new System.Drawing.Size(85, 85);
            this.pb_PumpIcon.TabIndex = 53;
            this.pb_PumpIcon.TabStop = false;
            // 
            // pb_HardnessIcon
            // 
            this.pb_HardnessIcon.Location = new System.Drawing.Point(32, 47);
            this.pb_HardnessIcon.Name = "pb_HardnessIcon";
            this.pb_HardnessIcon.Size = new System.Drawing.Size(85, 85);
            this.pb_HardnessIcon.TabIndex = 52;
            this.pb_HardnessIcon.TabStop = false;
            // 
            // sal_max
            // 
            this.sal_max.AutoSize = true;
            this.sal_max.Location = new System.Drawing.Point(780, 34);
            this.sal_max.Name = "sal_max";
            this.sal_max.Size = new System.Drawing.Size(41, 13);
            this.sal_max.TabIndex = 51;
            this.sal_max.Text = "label18";
            // 
            // htr_max
            // 
            this.htr_max.AutoSize = true;
            this.htr_max.Location = new System.Drawing.Point(88, 340);
            this.htr_max.Name = "htr_max";
            this.htr_max.Size = new System.Drawing.Size(41, 13);
            this.htr_max.TabIndex = 50;
            this.htr_max.Text = "label18";
            // 
            // hrd_max
            // 
            this.hrd_max.AutoSize = true;
            this.hrd_max.Location = new System.Drawing.Point(92, 34);
            this.hrd_max.Name = "hrd_max";
            this.hrd_max.Size = new System.Drawing.Size(41, 13);
            this.hrd_max.TabIndex = 48;
            this.hrd_max.Text = "label18";
            // 
            // amm_max
            // 
            this.amm_max.AutoSize = true;
            this.amm_max.Location = new System.Drawing.Point(802, 198);
            this.amm_max.Name = "amm_max";
            this.amm_max.Size = new System.Drawing.Size(41, 13);
            this.amm_max.TabIndex = 47;
            this.amm_max.Text = "label18";
            // 
            // nitrite_max
            // 
            this.nitrite_max.AutoSize = true;
            this.nitrite_max.Location = new System.Drawing.Point(794, 346);
            this.nitrite_max.Name = "nitrite_max";
            this.nitrite_max.Size = new System.Drawing.Size(41, 13);
            this.nitrite_max.TabIndex = 46;
            this.nitrite_max.Text = "label18";
            // 
            // nitrate_max
            // 
            this.nitrate_max.AutoSize = true;
            this.nitrate_max.Location = new System.Drawing.Point(587, 354);
            this.nitrate_max.Name = "nitrate_max";
            this.nitrate_max.Size = new System.Drawing.Size(41, 13);
            this.nitrate_max.TabIndex = 45;
            this.nitrate_max.Text = "label18";
            // 
            // nitrate_min
            // 
            this.nitrate_min.AutoSize = true;
            this.nitrate_min.Location = new System.Drawing.Point(525, 354);
            this.nitrate_min.Name = "nitrate_min";
            this.nitrate_min.Size = new System.Drawing.Size(41, 13);
            this.nitrate_min.TabIndex = 44;
            this.nitrate_min.Text = "label17";
            // 
            // nitrite_min
            // 
            this.nitrite_min.AutoSize = true;
            this.nitrite_min.Location = new System.Drawing.Point(729, 346);
            this.nitrite_min.Name = "nitrite_min";
            this.nitrite_min.Size = new System.Drawing.Size(41, 13);
            this.nitrite_min.TabIndex = 43;
            this.nitrite_min.Text = "label17";
            // 
            // amm_min
            // 
            this.amm_min.AutoSize = true;
            this.amm_min.Location = new System.Drawing.Point(729, 198);
            this.amm_min.Name = "amm_min";
            this.amm_min.Size = new System.Drawing.Size(41, 13);
            this.amm_min.TabIndex = 42;
            this.amm_min.Text = "label17";
            // 
            // htr_min
            // 
            this.htr_min.AutoSize = true;
            this.htr_min.Location = new System.Drawing.Point(16, 340);
            this.htr_min.Name = "htr_min";
            this.htr_min.Size = new System.Drawing.Size(41, 13);
            this.htr_min.TabIndex = 39;
            this.htr_min.Text = "label17";
            // 
            // sal_min
            // 
            this.sal_min.AutoSize = true;
            this.sal_min.Location = new System.Drawing.Point(729, 34);
            this.sal_min.Name = "sal_min";
            this.sal_min.Size = new System.Drawing.Size(41, 13);
            this.sal_min.TabIndex = 38;
            this.sal_min.Text = "label17";
            // 
            // ph_max
            // 
            this.ph_max.AutoSize = true;
            this.ph_max.Location = new System.Drawing.Point(283, 354);
            this.ph_max.Name = "ph_max";
            this.ph_max.Size = new System.Drawing.Size(41, 13);
            this.ph_max.TabIndex = 37;
            this.ph_max.Text = "label18";
            // 
            // ph_min
            // 
            this.ph_min.AutoSize = true;
            this.ph_min.Location = new System.Drawing.Point(213, 354);
            this.ph_min.Name = "ph_min";
            this.ph_min.Size = new System.Drawing.Size(41, 13);
            this.ph_min.TabIndex = 36;
            this.ph_min.Text = "label17";
            // 
            // sal_label
            // 
            this.sal_label.AutoSize = true;
            this.sal_label.Location = new System.Drawing.Point(780, 10);
            this.sal_label.Name = "sal_label";
            this.sal_label.Size = new System.Drawing.Size(41, 13);
            this.sal_label.TabIndex = 35;
            this.sal_label.Text = "label17";
            // 
            // ph_label
            // 
            this.ph_label.AutoSize = true;
            this.ph_label.Location = new System.Drawing.Point(290, 332);
            this.ph_label.Name = "ph_label";
            this.ph_label.Size = new System.Drawing.Size(41, 13);
            this.ph_label.TabIndex = 34;
            this.ph_label.Text = "label17";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(817, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "ppm";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(812, 297);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "mg/L";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(812, 448);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "mg/L";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(603, 452);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "mg/L";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(301, 452);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "pH";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(109, 440);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "°F";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(92, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "mg/ml";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "L/min";
            // 
            // lbl_Salinity_Value
            // 
            this.lbl_Salinity_Value.AutoSize = true;
            this.lbl_Salinity_Value.Location = new System.Drawing.Point(732, 132);
            this.lbl_Salinity_Value.Name = "lbl_Salinity_Value";
            this.lbl_Salinity_Value.Size = new System.Drawing.Size(35, 13);
            this.lbl_Salinity_Value.TabIndex = 15;
            this.lbl_Salinity_Value.Text = "label9";
            this.lbl_Salinity_Value.TextChanged += new System.EventHandler(this.CalcSalinityPidResponse);
            // 
            // lbl_Ammonia_Value
            // 
            this.lbl_Ammonia_Value.AutoSize = true;
            this.lbl_Ammonia_Value.Location = new System.Drawing.Point(732, 297);
            this.lbl_Ammonia_Value.Name = "lbl_Ammonia_Value";
            this.lbl_Ammonia_Value.Size = new System.Drawing.Size(35, 13);
            this.lbl_Ammonia_Value.TabIndex = 14;
            this.lbl_Ammonia_Value.Text = "label9";
            // 
            // lbl_Nitrite_Value
            // 
            this.lbl_Nitrite_Value.AutoSize = true;
            this.lbl_Nitrite_Value.Location = new System.Drawing.Point(732, 448);
            this.lbl_Nitrite_Value.Name = "lbl_Nitrite_Value";
            this.lbl_Nitrite_Value.Size = new System.Drawing.Size(35, 13);
            this.lbl_Nitrite_Value.TabIndex = 13;
            this.lbl_Nitrite_Value.Text = "label9";
            // 
            // lbl_Nitrate_Value
            // 
            this.lbl_Nitrate_Value.AutoSize = true;
            this.lbl_Nitrate_Value.Location = new System.Drawing.Point(525, 452);
            this.lbl_Nitrate_Value.Name = "lbl_Nitrate_Value";
            this.lbl_Nitrate_Value.Size = new System.Drawing.Size(35, 13);
            this.lbl_Nitrate_Value.TabIndex = 12;
            this.lbl_Nitrate_Value.Text = "label9";
            // 
            // lbl_Acidity_Value
            // 
            this.lbl_Acidity_Value.AutoSize = true;
            this.lbl_Acidity_Value.Location = new System.Drawing.Point(213, 452);
            this.lbl_Acidity_Value.Name = "lbl_Acidity_Value";
            this.lbl_Acidity_Value.Size = new System.Drawing.Size(35, 13);
            this.lbl_Acidity_Value.TabIndex = 11;
            this.lbl_Acidity_Value.Text = "label9";
            // 
            // lbl_Heater_Value
            // 
            this.lbl_Heater_Value.AutoSize = true;
            this.lbl_Heater_Value.Location = new System.Drawing.Point(19, 440);
            this.lbl_Heater_Value.Name = "lbl_Heater_Value";
            this.lbl_Heater_Value.Size = new System.Drawing.Size(35, 13);
            this.lbl_Heater_Value.TabIndex = 10;
            this.lbl_Heater_Value.Text = "label9";
            // 
            // lbl_Pump_Value
            // 
            this.lbl_Pump_Value.Location = new System.Drawing.Point(19, 297);
            this.lbl_Pump_Value.Name = "lbl_Pump_Value";
            this.lbl_Pump_Value.Size = new System.Drawing.Size(38, 13);
            this.lbl_Pump_Value.TabIndex = 9;
            this.lbl_Pump_Value.Text = "label9";
            // 
            // lbl_Hardness_Value
            // 
            this.lbl_Hardness_Value.AutoSize = true;
            this.lbl_Hardness_Value.Location = new System.Drawing.Point(19, 132);
            this.lbl_Hardness_Value.Name = "lbl_Hardness_Value";
            this.lbl_Hardness_Value.Size = new System.Drawing.Size(35, 13);
            this.lbl_Hardness_Value.TabIndex = 8;
            this.lbl_Hardness_Value.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(722, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Salinity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(722, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ammonia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(722, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nitrite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(516, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nitrate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ph Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Heater";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pump";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hardness";
            // 
            // acid_G_border
            // 
            this.acid_G_border.Image = ((System.Drawing.Image)(resources.GetObject("acid_G_border.Image")));
            this.acid_G_border.Location = new System.Drawing.Point(206, 349);
            this.acid_G_border.Name = "acid_G_border";
            this.acid_G_border.Size = new System.Drawing.Size(125, 125);
            this.acid_G_border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.acid_G_border.TabIndex = 18;
            this.acid_G_border.TabStop = false;
            // 
            // acid_R_border
            // 
            this.acid_R_border.Image = ((System.Drawing.Image)(resources.GetObject("acid_R_border.Image")));
            this.acid_R_border.Location = new System.Drawing.Point(206, 349);
            this.acid_R_border.Name = "acid_R_border";
            this.acid_R_border.Size = new System.Drawing.Size(125, 125);
            this.acid_R_border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.acid_R_border.TabIndex = 19;
            this.acid_R_border.TabStop = false;
            // 
            // sal_G_border
            // 
            this.sal_G_border.Image = ((System.Drawing.Image)(resources.GetObject("sal_G_border.Image")));
            this.sal_G_border.Location = new System.Drawing.Point(725, 29);
            this.sal_G_border.Name = "sal_G_border";
            this.sal_G_border.Size = new System.Drawing.Size(125, 125);
            this.sal_G_border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sal_G_border.TabIndex = 23;
            this.sal_G_border.TabStop = false;
            // 
            // sal_R_border
            // 
            this.sal_R_border.Image = ((System.Drawing.Image)(resources.GetObject("sal_R_border.Image")));
            this.sal_R_border.Location = new System.Drawing.Point(725, 29);
            this.sal_R_border.Name = "sal_R_border";
            this.sal_R_border.Size = new System.Drawing.Size(125, 125);
            this.sal_R_border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sal_R_border.TabIndex = 22;
            this.sal_R_border.TabStop = false;
            // 
            // htr_G_border
            // 
            this.htr_G_border.Image = ((System.Drawing.Image)(resources.GetObject("htr_G_border.Image")));
            this.htr_G_border.Location = new System.Drawing.Point(12, 336);
            this.htr_G_border.Name = "htr_G_border";
            this.htr_G_border.Size = new System.Drawing.Size(125, 125);
            this.htr_G_border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.htr_G_border.TabIndex = 20;
            this.htr_G_border.TabStop = false;
            // 
            // htr_R_border
            // 
            this.htr_R_border.Image = ((System.Drawing.Image)(resources.GetObject("htr_R_border.Image")));
            this.htr_R_border.Location = new System.Drawing.Point(12, 336);
            this.htr_R_border.Name = "htr_R_border";
            this.htr_R_border.Size = new System.Drawing.Size(125, 125);
            this.htr_R_border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.htr_R_border.TabIndex = 21;
            this.htr_R_border.TabStop = false;
            // 
            // hrd_G_border
            // 
            this.hrd_G_border.Image = ((System.Drawing.Image)(resources.GetObject("hrd_G_border.Image")));
            this.hrd_G_border.Location = new System.Drawing.Point(12, 29);
            this.hrd_G_border.Name = "hrd_G_border";
            this.hrd_G_border.Size = new System.Drawing.Size(125, 125);
            this.hrd_G_border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hrd_G_border.TabIndex = 26;
            this.hrd_G_border.TabStop = false;
            // 
            // pump_G_border
            // 
            this.pump_G_border.Image = ((System.Drawing.Image)(resources.GetObject("pump_G_border.Image")));
            this.pump_G_border.Location = new System.Drawing.Point(12, 189);
            this.pump_G_border.Name = "pump_G_border";
            this.pump_G_border.Size = new System.Drawing.Size(125, 125);
            this.pump_G_border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pump_G_border.TabIndex = 25;
            this.pump_G_border.TabStop = false;
            // 
            // pump_R_border
            // 
            this.pump_R_border.Image = ((System.Drawing.Image)(resources.GetObject("pump_R_border.Image")));
            this.pump_R_border.Location = new System.Drawing.Point(11, 189);
            this.pump_R_border.Name = "pump_R_border";
            this.pump_R_border.Size = new System.Drawing.Size(125, 125);
            this.pump_R_border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pump_R_border.TabIndex = 32;
            this.pump_R_border.TabStop = false;
            // 
            // hrd_R_border
            // 
            this.hrd_R_border.Image = ((System.Drawing.Image)(resources.GetObject("hrd_R_border.Image")));
            this.hrd_R_border.Location = new System.Drawing.Point(12, 29);
            this.hrd_R_border.Name = "hrd_R_border";
            this.hrd_R_border.Size = new System.Drawing.Size(125, 125);
            this.hrd_R_border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hrd_R_border.TabIndex = 33;
            this.hrd_R_border.TabStop = false;
            // 
            // amm_G_border
            // 
            this.amm_G_border.Image = ((System.Drawing.Image)(resources.GetObject("amm_G_border.Image")));
            this.amm_G_border.Location = new System.Drawing.Point(725, 193);
            this.amm_G_border.Name = "amm_G_border";
            this.amm_G_border.Size = new System.Drawing.Size(125, 125);
            this.amm_G_border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.amm_G_border.TabIndex = 24;
            this.amm_G_border.TabStop = false;
            // 
            // amm_R_border
            // 
            this.amm_R_border.Image = ((System.Drawing.Image)(resources.GetObject("amm_R_border.Image")));
            this.amm_R_border.Location = new System.Drawing.Point(725, 193);
            this.amm_R_border.Name = "amm_R_border";
            this.amm_R_border.Size = new System.Drawing.Size(125, 125);
            this.amm_R_border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.amm_R_border.TabIndex = 31;
            this.amm_R_border.TabStop = false;
            // 
            // nitrite_G_border
            // 
            this.nitrite_G_border.Image = ((System.Drawing.Image)(resources.GetObject("nitrite_G_border.Image")));
            this.nitrite_G_border.Location = new System.Drawing.Point(724, 340);
            this.nitrite_G_border.Name = "nitrite_G_border";
            this.nitrite_G_border.Size = new System.Drawing.Size(125, 125);
            this.nitrite_G_border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.nitrite_G_border.TabIndex = 28;
            this.nitrite_G_border.TabStop = false;
            // 
            // nitrite_R_border
            // 
            this.nitrite_R_border.Image = ((System.Drawing.Image)(resources.GetObject("nitrite_R_border.Image")));
            this.nitrite_R_border.Location = new System.Drawing.Point(724, 340);
            this.nitrite_R_border.Name = "nitrite_R_border";
            this.nitrite_R_border.Size = new System.Drawing.Size(125, 125);
            this.nitrite_R_border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.nitrite_R_border.TabIndex = 30;
            this.nitrite_R_border.TabStop = false;
            // 
            // nitrate_G_border
            // 
            this.nitrate_G_border.Image = ((System.Drawing.Image)(resources.GetObject("nitrate_G_border.Image")));
            this.nitrate_G_border.Location = new System.Drawing.Point(519, 349);
            this.nitrate_G_border.Name = "nitrate_G_border";
            this.nitrate_G_border.Size = new System.Drawing.Size(125, 125);
            this.nitrate_G_border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.nitrate_G_border.TabIndex = 27;
            this.nitrate_G_border.TabStop = false;
            // 
            // nitrate_R_border
            // 
            this.nitrate_R_border.Image = ((System.Drawing.Image)(resources.GetObject("nitrate_R_border.Image")));
            this.nitrate_R_border.Location = new System.Drawing.Point(519, 349);
            this.nitrate_R_border.Name = "nitrate_R_border";
            this.nitrate_R_border.Size = new System.Drawing.Size(125, 125);
            this.nitrate_R_border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.nitrate_R_border.TabIndex = 29;
            this.nitrate_R_border.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_Auto);
            this.flowLayoutPanel1.Controls.Add(this.btn_Manual);
            this.flowLayoutPanel1.Controls.Add(this.btn_Settings);
            this.flowLayoutPanel1.Controls.Add(this.btn_Alarms);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 527);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(854, 74);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_Auto
            // 
            this.btn_Auto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Auto.Location = new System.Drawing.Point(3, 3);
            this.btn_Auto.Name = "btn_Auto";
            this.btn_Auto.Size = new System.Drawing.Size(106, 71);
            this.btn_Auto.TabIndex = 0;
            this.btn_Auto.Text = "Auto Mode";
            this.btn_Auto.UseVisualStyleBackColor = true;
            this.btn_Auto.Click += new System.EventHandler(this.btn_AutoMode_Click);
            // 
            // btn_Manual
            // 
            this.btn_Manual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Manual.Location = new System.Drawing.Point(115, 3);
            this.btn_Manual.Name = "btn_Manual";
            this.btn_Manual.Size = new System.Drawing.Size(106, 71);
            this.btn_Manual.TabIndex = 1;
            this.btn_Manual.Text = "Manual Mode";
            this.btn_Manual.UseVisualStyleBackColor = true;
            this.btn_Manual.Click += new System.EventHandler(this.btn_Manual_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Settings.Location = new System.Drawing.Point(227, 3);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(117, 71);
            this.btn_Settings.TabIndex = 2;
            this.btn_Settings.Text = "Settings";
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btn_Alarms
            // 
            this.btn_Alarms.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alarms.Location = new System.Drawing.Point(350, 3);
            this.btn_Alarms.Name = "btn_Alarms";
            this.btn_Alarms.Size = new System.Drawing.Size(106, 71);
            this.btn_Alarms.TabIndex = 3;
            this.btn_Alarms.Text = "Alarms";
            this.btn_Alarms.UseVisualStyleBackColor = true;
            this.btn_Alarms.Click += new System.EventHandler(this.btn_Alarms_Click);
            // 
            // pnl_FaultBanner
            // 
            this.pnl_FaultBanner.BackColor = System.Drawing.Color.IndianRed;
            this.pnl_FaultBanner.Controls.Add(this.lbl_Alarms);
            this.pnl_FaultBanner.Location = new System.Drawing.Point(0, -1);
            this.pnl_FaultBanner.Name = "pnl_FaultBanner";
            this.pnl_FaultBanner.Size = new System.Drawing.Size(863, 47);
            this.pnl_FaultBanner.TabIndex = 1;
            // 
            // lbl_Alarms
            // 
            this.lbl_Alarms.AutoSize = true;
            this.lbl_Alarms.ForeColor = System.Drawing.Color.White;
            this.lbl_Alarms.Location = new System.Drawing.Point(12, 19);
            this.lbl_Alarms.Name = "lbl_Alarms";
            this.lbl_Alarms.Size = new System.Drawing.Size(35, 13);
            this.lbl_Alarms.TabIndex = 0;
            this.lbl_Alarms.Text = "label9";
            // 
            // timerReadings
            // 
            this.timerReadings.Enabled = true;
            this.timerReadings.Interval = 250D;
            this.timerReadings.SynchronizingObject = this;
            // 
            // timerMessages
            // 
            this.timerMessages.Enabled = false;
            this.timerMessages.Interval = 1000D;
            this.timerMessages.SynchronizingObject = this;

            this.VisibleChanged += new System.EventHandler(StartTimer);
            // 
            // TankGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 603);
            this.Controls.Add(this.pnl_FaultBanner);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(878, 642);
            this.MinimumSize = new System.Drawing.Size(878, 642);
            this.Name = "TankGui";
            this.Text = "Overview";
            this.Load += new System.EventHandler(this.TankGui_Load);
            this.Shown += new System.EventHandler(this.AddGlobalUpdateHandler);
            this.VisibleChanged += new System.EventHandler(this.SetMode);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NitriteIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AmmoniaIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SalinityIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NitrateIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PhIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_HeaterIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PumpIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_HardnessIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acid_G_border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acid_R_border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sal_G_border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sal_R_border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.htr_G_border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.htr_R_border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrd_G_border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pump_G_border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pump_R_border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrd_R_border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amm_G_border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amm_R_border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nitrite_G_border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nitrite_R_border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nitrate_G_border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nitrate_R_border)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnl_FaultBanner.ResumeLayout(false);
            this.pnl_FaultBanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerReadings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerMessages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_Auto;
        private System.Windows.Forms.Button btn_Manual;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Button btn_Alarms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Hardness_Value;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Salinity_Value;
        private System.Windows.Forms.Label lbl_Ammonia_Value;
        private System.Windows.Forms.Label lbl_Nitrite_Value;
        private System.Windows.Forms.Label lbl_Nitrate_Value;
        private System.Windows.Forms.Label lbl_Acidity_Value;
        private System.Windows.Forms.Label lbl_Heater_Value;
        private System.Windows.Forms.Label lbl_Pump_Value;
        private System.Windows.Forms.Panel pnl_FaultBanner;
        private System.Windows.Forms.Label lbl_Alarms;
        private Timer timerReadings;
        private Timer timerMessages;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox acid_G_border;
        private System.Windows.Forms.PictureBox acid_R_border;
        private System.Windows.Forms.PictureBox sal_G_border;
        private System.Windows.Forms.PictureBox sal_R_border;
        private System.Windows.Forms.PictureBox htr_G_border;
        private System.Windows.Forms.PictureBox htr_R_border;
        private System.Windows.Forms.PictureBox nitrite_G_border;
        private System.Windows.Forms.PictureBox nitrate_G_border;
        private System.Windows.Forms.PictureBox hrd_G_border;
        private System.Windows.Forms.PictureBox pump_G_border;
        private System.Windows.Forms.PictureBox amm_G_border;
        private System.Windows.Forms.PictureBox pump_R_border;
        private System.Windows.Forms.PictureBox amm_R_border;
        private System.Windows.Forms.PictureBox nitrite_R_border;
        private System.Windows.Forms.PictureBox nitrate_R_border;
        private System.Windows.Forms.PictureBox hrd_R_border;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ph_label;
        private System.Windows.Forms.Label sal_label;
        private System.Windows.Forms.Label ph_max;
        private System.Windows.Forms.Label ph_min;
        private System.Windows.Forms.Label sal_max;
        private System.Windows.Forms.Label htr_max;
        private System.Windows.Forms.Label amm_max;
        private System.Windows.Forms.Label nitrite_max;
        private System.Windows.Forms.Label nitrate_max;
        private System.Windows.Forms.Label nitrate_min;
        private System.Windows.Forms.Label nitrite_min;
        private System.Windows.Forms.Label amm_min;
        private System.Windows.Forms.Label htr_min;
        private System.Windows.Forms.Label sal_min;
        private System.Windows.Forms.Label hrd_max;
        private System.Windows.Forms.PictureBox pb_NitriteIcon;
        private System.Windows.Forms.PictureBox pb_AmmoniaIcon;
        private System.Windows.Forms.PictureBox pb_SalinityIcon;
        private System.Windows.Forms.PictureBox pb_NitrateIcon;
        private System.Windows.Forms.PictureBox pb_PhIcon;
        private System.Windows.Forms.PictureBox pb_HeaterIcon;
        private System.Windows.Forms.PictureBox pb_PumpIcon;
        private System.Windows.Forms.PictureBox pb_HardnessIcon;
        private System.Windows.Forms.Label Ammonia_lbl;
        private System.Windows.Forms.Label Nitrite_lbl;
        private System.Windows.Forms.Label Nitrate_lbl;
    }
}


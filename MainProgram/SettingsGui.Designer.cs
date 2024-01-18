
using System;
using System.Timers;

namespace MainProgram
{
    partial class SettingsGui
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Auto = new System.Windows.Forms.Button();
            this.btn_Manual = new System.Windows.Forms.Button();
            this.btn_Overview = new System.Windows.Forms.Button();
            this.btn_Alarms = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_DisconnectMessageResult = new System.Windows.Forms.Panel();
            this.lbl_DisconnectMessage = new System.Windows.Forms.Label();
            this.pnl_ConnectMessageResult = new System.Windows.Forms.Panel();
            this.lbl_ConnectMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_ToAdd = new System.Windows.Forms.ComboBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.lbl_Operating = new System.Windows.Forms.Label();
            this.btn_IncreaseOperating = new System.Windows.Forms.Button();
            this.lbl_OperatingValue = new System.Windows.Forms.Label();
            this.btn_DecreaseOperating = new System.Windows.Forms.Button();
            this.btn_IncreaseLower = new System.Windows.Forms.Button();
            this.lbl_LowerThreshold = new System.Windows.Forms.Label();
            this.btn_DecreaseLower = new System.Windows.Forms.Button();
            this.lbl_Lower = new System.Windows.Forms.Label();
            this.lbl_Upper = new System.Windows.Forms.Label();
            this.pb_IconImage = new System.Windows.Forms.PictureBox();
            this.btn_SetValue = new System.Windows.Forms.Button();
            this.btn_IncreaseUpper = new System.Windows.Forms.Button();
            this.lbl_UpperThreshold = new System.Windows.Forms.Label();
            this.btn_DecreaseUpper = new System.Windows.Forms.Button();
            this.lbl_DevicesTitle = new System.Windows.Forms.Label();
            this.lb_Devices = new System.Windows.Forms.ListBox();
            this.pnl_FaultBanner = new System.Windows.Forms.Panel();
            this.lbl_Alarms = new System.Windows.Forms.Label();
            this.timerMessages = new System.Timers.Timer();
            this.timerStatuses = new System.Timers.Timer();
            this.timer_AddRemoveMessages = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_DisconnectMessageResult.SuspendLayout();
            this.pnl_ConnectMessageResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_IconImage)).BeginInit();
            this.pnl_FaultBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerStatuses)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_Auto);
            this.flowLayoutPanel1.Controls.Add(this.btn_Manual);
            this.flowLayoutPanel1.Controls.Add(this.btn_Overview);
            this.flowLayoutPanel1.Controls.Add(this.btn_Alarms);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 527);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(853, 74);
            this.flowLayoutPanel1.TabIndex = 1;
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
            // btn_Overview
            // 
            this.btn_Overview.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Overview.Location = new System.Drawing.Point(227, 3);
            this.btn_Overview.Name = "btn_Overview";
            this.btn_Overview.Size = new System.Drawing.Size(117, 71);
            this.btn_Overview.TabIndex = 2;
            this.btn_Overview.Text = "Overview";
            this.btn_Overview.UseVisualStyleBackColor = true;
            this.btn_Overview.Click += new System.EventHandler(this.btn_Overview_Click);
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
            this.btn_Alarms.Click += new System.EventHandler(this.btn_Alarms_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnl_DisconnectMessageResult);
            this.panel1.Controls.Add(this.pnl_ConnectMessageResult);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_ToAdd);
            this.panel1.Controls.Add(this.btn_Connect);
            this.panel1.Controls.Add(this.btn_Disconnect);
            this.panel1.Controls.Add(this.lbl_Operating);
            this.panel1.Controls.Add(this.btn_IncreaseOperating);
            this.panel1.Controls.Add(this.lbl_OperatingValue);
            this.panel1.Controls.Add(this.btn_DecreaseOperating);
            this.panel1.Controls.Add(this.btn_IncreaseLower);
            this.panel1.Controls.Add(this.lbl_LowerThreshold);
            this.panel1.Controls.Add(this.btn_DecreaseLower);
            this.panel1.Controls.Add(this.lbl_Lower);
            this.panel1.Controls.Add(this.lbl_Upper);
            this.panel1.Controls.Add(this.pb_IconImage);
            this.panel1.Controls.Add(this.btn_SetValue);
            this.panel1.Controls.Add(this.btn_IncreaseUpper);
            this.panel1.Controls.Add(this.lbl_UpperThreshold);
            this.panel1.Controls.Add(this.btn_DecreaseUpper);
            this.panel1.Controls.Add(this.lbl_DevicesTitle);
            this.panel1.Controls.Add(this.lb_Devices);
            this.panel1.Location = new System.Drawing.Point(1, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 479);
            this.panel1.TabIndex = 2;
            // 
            // pnl_DisconnectMessageResult
            // 
            this.pnl_DisconnectMessageResult.Controls.Add(this.lbl_DisconnectMessage);
            this.pnl_DisconnectMessageResult.Location = new System.Drawing.Point(157, 417);
            this.pnl_DisconnectMessageResult.Name = "pnl_DisconnectMessageResult";
            this.pnl_DisconnectMessageResult.Size = new System.Drawing.Size(125, 21);
            this.pnl_DisconnectMessageResult.TabIndex = 22;
            // 
            // lbl_DisconnectMessage
            // 
            this.lbl_DisconnectMessage.AutoSize = true;
            this.lbl_DisconnectMessage.Location = new System.Drawing.Point(3, 4);
            this.lbl_DisconnectMessage.Name = "lbl_DisconnectMessage";
            this.lbl_DisconnectMessage.Size = new System.Drawing.Size(35, 13);
            this.lbl_DisconnectMessage.TabIndex = 0;
            this.lbl_DisconnectMessage.Text = "label2";
            // 
            // pnl_ConnectMessageResult
            // 
            this.pnl_ConnectMessageResult.Controls.Add(this.lbl_ConnectMessage);
            this.pnl_ConnectMessageResult.Location = new System.Drawing.Point(183, 43);
            this.pnl_ConnectMessageResult.Name = "pnl_ConnectMessageResult";
            this.pnl_ConnectMessageResult.Size = new System.Drawing.Size(133, 21);
            this.pnl_ConnectMessageResult.TabIndex = 21;
            // 
            // lbl_ConnectMessage
            // 
            this.lbl_ConnectMessage.AutoSize = true;
            this.lbl_ConnectMessage.Location = new System.Drawing.Point(3, 4);
            this.lbl_ConnectMessage.Name = "lbl_ConnectMessage";
            this.lbl_ConnectMessage.Size = new System.Drawing.Size(35, 13);
            this.lbl_ConnectMessage.TabIndex = 0;
            this.lbl_ConnectMessage.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Select type to add:";
            // 
            // cb_ToAdd
            // 
            this.cb_ToAdd.FormattingEnabled = true;
            this.cb_ToAdd.Items.AddRange(new object[] {
            "Pump",
            "Heater",
            "Ph Sensor",
            "Nitrate Sensor",
            "Nitrite Sensor",
            "Ammonia Sensor",
            "Salinity Sensor",
            "Hardness Sensor"});
            this.cb_ToAdd.Location = new System.Drawing.Point(11, 43);
            this.cb_ToAdd.Name = "cb_ToAdd";
            this.cb_ToAdd.Size = new System.Drawing.Size(96, 21);
            this.cb_ToAdd.TabIndex = 19;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(115, 42);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(61, 23);
            this.btn_Connect.TabIndex = 18;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Location = new System.Drawing.Point(32, 415);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(119, 23);
            this.btn_Disconnect.TabIndex = 17;
            this.btn_Disconnect.Text = "Disconnect Selected";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // lbl_Operating
            // 
            this.lbl_Operating.AutoSize = true;
            this.lbl_Operating.Location = new System.Drawing.Point(387, 214);
            this.lbl_Operating.Name = "lbl_Operating";
            this.lbl_Operating.Size = new System.Drawing.Size(86, 13);
            this.lbl_Operating.TabIndex = 16;
            this.lbl_Operating.Text = "Operating Value:";
            // 
            // btn_IncreaseOperating
            // 
            this.btn_IncreaseOperating.Location = new System.Drawing.Point(546, 242);
            this.btn_IncreaseOperating.Name = "btn_IncreaseOperating";
            this.btn_IncreaseOperating.Size = new System.Drawing.Size(65, 47);
            this.btn_IncreaseOperating.TabIndex = 15;
            this.btn_IncreaseOperating.Text = "Up";
            this.btn_IncreaseOperating.UseVisualStyleBackColor = true;
            this.btn_IncreaseOperating.Click += new System.EventHandler(this.btn_IncreaseOperating_Click);
            // 
            // lbl_OperatingValue
            // 
            this.lbl_OperatingValue.AutoSize = true;
            this.lbl_OperatingValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OperatingValue.Location = new System.Drawing.Point(467, 254);
            this.lbl_OperatingValue.Name = "lbl_OperatingValue";
            this.lbl_OperatingValue.Size = new System.Drawing.Size(60, 24);
            this.lbl_OperatingValue.TabIndex = 14;
            this.lbl_OperatingValue.Text = "label1";
            // 
            // btn_DecreaseOperating
            // 
            this.btn_DecreaseOperating.Location = new System.Drawing.Point(387, 242);
            this.btn_DecreaseOperating.Name = "btn_DecreaseOperating";
            this.btn_DecreaseOperating.Size = new System.Drawing.Size(65, 47);
            this.btn_DecreaseOperating.TabIndex = 13;
            this.btn_DecreaseOperating.Text = "Down";
            this.btn_DecreaseOperating.UseVisualStyleBackColor = true;
            this.btn_DecreaseOperating.Click += new System.EventHandler(this.btn_DecreaseOperating_Click);
            // 
            // btn_IncreaseLower
            // 
            this.btn_IncreaseLower.Enabled = false;
            this.btn_IncreaseLower.Location = new System.Drawing.Point(546, 321);
            this.btn_IncreaseLower.Name = "btn_IncreaseLower";
            this.btn_IncreaseLower.Size = new System.Drawing.Size(65, 47);
            this.btn_IncreaseLower.TabIndex = 12;
            this.btn_IncreaseLower.Text = "Up";
            this.btn_IncreaseLower.UseVisualStyleBackColor = true;
            this.btn_IncreaseLower.Click += new System.EventHandler(this.btn_IncreaseLower_Click);
            // 
            // lbl_LowerThreshold
            // 
            this.lbl_LowerThreshold.AutoSize = true;
            this.lbl_LowerThreshold.Enabled = false;
            this.lbl_LowerThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LowerThreshold.Location = new System.Drawing.Point(467, 333);
            this.lbl_LowerThreshold.Name = "lbl_LowerThreshold";
            this.lbl_LowerThreshold.Size = new System.Drawing.Size(60, 24);
            this.lbl_LowerThreshold.TabIndex = 11;
            this.lbl_LowerThreshold.Text = "label1";
            // 
            // btn_DecreaseLower
            // 
            this.btn_DecreaseLower.Enabled = false;
            this.btn_DecreaseLower.Location = new System.Drawing.Point(387, 321);
            this.btn_DecreaseLower.Name = "btn_DecreaseLower";
            this.btn_DecreaseLower.Size = new System.Drawing.Size(65, 47);
            this.btn_DecreaseLower.TabIndex = 10;
            this.btn_DecreaseLower.Text = "Down";
            this.btn_DecreaseLower.UseVisualStyleBackColor = true;
            this.btn_DecreaseLower.Click += new System.EventHandler(this.btn_DecreaseLower_Click);
            // 
            // lbl_Lower
            // 
            this.lbl_Lower.AutoSize = true;
            this.lbl_Lower.Enabled = false;
            this.lbl_Lower.Location = new System.Drawing.Point(387, 296);
            this.lbl_Lower.Name = "lbl_Lower";
            this.lbl_Lower.Size = new System.Drawing.Size(89, 13);
            this.lbl_Lower.TabIndex = 9;
            this.lbl_Lower.Text = "Lower Threshold:";
            // 
            // lbl_Upper
            // 
            this.lbl_Upper.AutoSize = true;
            this.lbl_Upper.Enabled = false;
            this.lbl_Upper.Location = new System.Drawing.Point(387, 128);
            this.lbl_Upper.Name = "lbl_Upper";
            this.lbl_Upper.Size = new System.Drawing.Size(89, 13);
            this.lbl_Upper.TabIndex = 8;
            this.lbl_Upper.Text = "Upper Threshold:";
            // 
            // pb_IconImage
            // 
            this.pb_IconImage.Location = new System.Drawing.Point(273, 219);
            this.pb_IconImage.Name = "pb_IconImage";
            this.pb_IconImage.Size = new System.Drawing.Size(85, 85);
            this.pb_IconImage.TabIndex = 7;
            this.pb_IconImage.TabStop = false;
            // 
            // btn_SetValue
            // 
            this.btn_SetValue.Location = new System.Drawing.Point(713, 242);
            this.btn_SetValue.Name = "btn_SetValue";
            this.btn_SetValue.Size = new System.Drawing.Size(102, 44);
            this.btn_SetValue.TabIndex = 6;
            this.btn_SetValue.Text = "SET";
            this.btn_SetValue.UseVisualStyleBackColor = true;
            this.btn_SetValue.Click += new System.EventHandler(this.btn_SetValue_Click);
            // 
            // btn_IncreaseUpper
            // 
            this.btn_IncreaseUpper.Enabled = false;
            this.btn_IncreaseUpper.Location = new System.Drawing.Point(546, 156);
            this.btn_IncreaseUpper.Name = "btn_IncreaseUpper";
            this.btn_IncreaseUpper.Size = new System.Drawing.Size(65, 47);
            this.btn_IncreaseUpper.TabIndex = 5;
            this.btn_IncreaseUpper.Text = "Up";
            this.btn_IncreaseUpper.UseVisualStyleBackColor = true;
            this.btn_IncreaseUpper.Click += new System.EventHandler(this.btn_IncreaseUpper_Click);
            // 
            // lbl_UpperThreshold
            // 
            this.lbl_UpperThreshold.AutoSize = true;
            this.lbl_UpperThreshold.Enabled = false;
            this.lbl_UpperThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UpperThreshold.Location = new System.Drawing.Point(467, 168);
            this.lbl_UpperThreshold.Name = "lbl_UpperThreshold";
            this.lbl_UpperThreshold.Size = new System.Drawing.Size(60, 24);
            this.lbl_UpperThreshold.TabIndex = 4;
            this.lbl_UpperThreshold.Text = "label1";
            // 
            // btn_DecreaseUpper
            // 
            this.btn_DecreaseUpper.Enabled = false;
            this.btn_DecreaseUpper.Location = new System.Drawing.Point(387, 156);
            this.btn_DecreaseUpper.Name = "btn_DecreaseUpper";
            this.btn_DecreaseUpper.Size = new System.Drawing.Size(65, 47);
            this.btn_DecreaseUpper.TabIndex = 3;
            this.btn_DecreaseUpper.Text = "Down";
            this.btn_DecreaseUpper.UseVisualStyleBackColor = true;
            this.btn_DecreaseUpper.Click += new System.EventHandler(this.btn_DecreaseUpper_Click);
            // 
            // lbl_DevicesTitle
            // 
            this.lbl_DevicesTitle.AutoSize = true;
            this.lbl_DevicesTitle.Location = new System.Drawing.Point(12, 90);
            this.lbl_DevicesTitle.Name = "lbl_DevicesTitle";
            this.lbl_DevicesTitle.Size = new System.Drawing.Size(49, 13);
            this.lbl_DevicesTitle.TabIndex = 1;
            this.lbl_DevicesTitle.Text = "Devices:";
            // 
            // lb_Devices
            // 
            this.lb_Devices.FormattingEnabled = true;
            this.lb_Devices.Location = new System.Drawing.Point(11, 106);
            this.lb_Devices.Name = "lb_Devices";
            this.lb_Devices.Size = new System.Drawing.Size(165, 303);
            this.lb_Devices.TabIndex = 0;
            this.lb_Devices.SelectedIndexChanged += new EventHandler(ChangedSelection);
            // 
            // pnl_FaultBanner
            // 
            this.pnl_FaultBanner.BackColor = System.Drawing.Color.IndianRed;
            this.pnl_FaultBanner.Controls.Add(this.lbl_Alarms);
            this.pnl_FaultBanner.Location = new System.Drawing.Point(0, 0);
            this.pnl_FaultBanner.Name = "pnl_FaultBanner";
            this.pnl_FaultBanner.Size = new System.Drawing.Size(864, 45);
            this.pnl_FaultBanner.TabIndex = 3;
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
            // timerMessages
            // 
            this.timerMessages.Enabled = false;
            this.timerMessages.Interval = 5000D;
            this.timerMessages.SynchronizingObject = this;

            this.VisibleChanged += new System.EventHandler(StartTimer);
            // 
            // timerStatuses
            // 
            this.timerStatuses.Enabled = true;
            this.timerStatuses.Interval = 250D;
            this.timerStatuses.SynchronizingObject = this;
            // 
            // timer_AddRemoveMessages
            // 
            this.timer_AddRemoveMessages.Interval = 1000;
            this.timer_AddRemoveMessages.Tick += new System.EventHandler(this.ResetDeviceAddRemoveLabel);
            // 
            // SettingsGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 603);
            this.Controls.Add(this.pnl_FaultBanner);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(878, 642);
            this.MinimumSize = new System.Drawing.Size(878, 642);
            this.Name = "SettingsGui";
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosing);
            this.Load += new System.EventHandler(this.SettingsGui_Load);
            this.Shown += new System.EventHandler(this.AddGlobalUpdateHandler);
            this.VisibleChanged += new System.EventHandler(this.SetMode);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_DisconnectMessageResult.ResumeLayout(false);
            this.pnl_DisconnectMessageResult.PerformLayout();
            this.pnl_ConnectMessageResult.ResumeLayout(false);
            this.pnl_ConnectMessageResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_IconImage)).EndInit();
            this.pnl_FaultBanner.ResumeLayout(false);
            this.pnl_FaultBanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerStatuses)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_Auto;
        private System.Windows.Forms.Button btn_Manual;
        private System.Windows.Forms.Button btn_Overview;
        private System.Windows.Forms.Button btn_Alarms;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_FaultBanner;
        private System.Windows.Forms.Label lbl_Alarms;
        private System.Windows.Forms.Label lbl_DevicesTitle;
        private System.Windows.Forms.ListBox lb_Devices;
        private System.Windows.Forms.Button btn_SetValue;
        private System.Windows.Forms.Button btn_IncreaseUpper;
        private System.Windows.Forms.Label lbl_UpperThreshold;
        private System.Windows.Forms.Button btn_DecreaseUpper;
        private System.Windows.Forms.PictureBox pb_IconImage;
        private System.Windows.Forms.Label lbl_Upper;
        private System.Windows.Forms.Button btn_IncreaseLower;
        private System.Windows.Forms.Label lbl_LowerThreshold;
        private System.Windows.Forms.Button btn_DecreaseLower;
        private System.Windows.Forms.Label lbl_Lower;
        private System.Windows.Forms.Label lbl_Operating;
        private System.Windows.Forms.Button btn_IncreaseOperating;
        private System.Windows.Forms.Label lbl_OperatingValue;
        private System.Windows.Forms.Button btn_DecreaseOperating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_ToAdd;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_Disconnect;
        private Timer timerMessages;
        private Timer timerStatuses;
        private System.Windows.Forms.Panel pnl_DisconnectMessageResult;
        private System.Windows.Forms.Label lbl_DisconnectMessage;
        private System.Windows.Forms.Panel pnl_ConnectMessageResult;
        private System.Windows.Forms.Label lbl_ConnectMessage;
        private System.Windows.Forms.Timer timer_AddRemoveMessages;
        private System.Windows.Forms.Timer timer1;
    }
}




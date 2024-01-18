
using System;
using System.Timers;

namespace MainProgram
{
    partial class AlarmsGui
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
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Acknowledge = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ClearAll = new System.Windows.Forms.Button();
            this.pnl_FaultBanner = new System.Windows.Forms.Panel();
            this.lbl_Alarms = new System.Windows.Forms.Label();
            this.timerStatuses = new System.Windows.Forms.Timer(this.components);
            this.timerListBox = new System.Windows.Forms.Timer(this.components);
            this.timer_DispayMessages = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_FaultBanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_Auto);
            this.flowLayoutPanel1.Controls.Add(this.btn_Manual);
            this.flowLayoutPanel1.Controls.Add(this.btn_Overview);
            this.flowLayoutPanel1.Controls.Add(this.btn_Settings);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 527);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(853, 74);
            this.flowLayoutPanel1.TabIndex = 2;
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
            this.btn_Auto.Click += new System.EventHandler(this.btn_Auto_Click);
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
            this.btn_Overview.Click += new System.EventHandler(this.btn_Overview_Click_1);
            // 
            // btn_Settings
            // 
            this.btn_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Settings.Location = new System.Drawing.Point(350, 3);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(106, 71);
            this.btn_Settings.TabIndex = 3;
            this.btn_Settings.Text = "Settings";
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.Location = new System.Drawing.Point(775, 93);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(75, 61);
            this.btn_Previous.TabIndex = 4;
            this.btn_Previous.Text = "Up";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(775, 160);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 61);
            this.btn_Next.TabIndex = 3;
            this.btn_Next.Text = "Down";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Acknowledge
            // 
            this.btn_Acknowledge.Location = new System.Drawing.Point(776, 322);
            this.btn_Acknowledge.Name = "btn_Acknowledge";
            this.btn_Acknowledge.Size = new System.Drawing.Size(75, 61);
            this.btn_Acknowledge.TabIndex = 1;
            this.btn_Acknowledge.Text = "Aknowledge";
            this.btn_Acknowledge.UseVisualStyleBackColor = true;
            this.btn_Acknowledge.Click += new System.EventHandler(this.btn_Acknowledge_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Firebrick;
            this.listBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(764, 472);
            this.listBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ClearAll);
            this.panel1.Controls.Add(this.btn_Previous);
            this.panel1.Controls.Add(this.btn_Next);
            this.panel1.Controls.Add(this.btn_Acknowledge);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(1, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 479);
            this.panel1.TabIndex = 3;
            // 
            // btn_ClearAll
            // 
            this.btn_ClearAll.Location = new System.Drawing.Point(775, 255);
            this.btn_ClearAll.Name = "btn_ClearAll";
            this.btn_ClearAll.Size = new System.Drawing.Size(75, 61);
            this.btn_ClearAll.TabIndex = 5;
            this.btn_ClearAll.Text = "Clear All";
            this.btn_ClearAll.UseVisualStyleBackColor = true;
            this.btn_ClearAll.Click += new System.EventHandler(this.btn_ClearAll_Click);
            // 
            // pnl_FaultBanner
            // 
            this.pnl_FaultBanner.BackColor = System.Drawing.Color.IndianRed;
            this.pnl_FaultBanner.Controls.Add(this.lbl_Alarms);
            this.pnl_FaultBanner.Location = new System.Drawing.Point(1, 0);
            this.pnl_FaultBanner.Name = "pnl_FaultBanner";
            this.pnl_FaultBanner.Size = new System.Drawing.Size(863, 45);
            this.pnl_FaultBanner.TabIndex = 4;
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
            // timerStatuses
            // 
            this.timerStatuses.Enabled = true;
            this.timerStatuses.Interval = 250;
            this.timerStatuses.Tick += new System.EventHandler(this.timerStatuses_Tick);
            // 
            // timerListBox
            // 
            this.timerListBox.Enabled = true;
            this.timerListBox.Interval = 500;
            this.timerListBox.Tick += new System.EventHandler(this.timerListBox_Tick);
            // 
            // timer_DispayMessages
            // 
            this.timer_DispayMessages.Enabled = false;
            this.timer_DispayMessages.Interval = 1000;
            this.timer_DispayMessages.Tick += new System.EventHandler(this.DisplayMessages);


            this.VisibleChanged += new System.EventHandler(StartTimer);
            // 
            // AlarmsGui
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
            this.Name = "AlarmsGui";
            this.Text = "Alarms";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosing);
            this.Load += new System.EventHandler(this.AlarmsGui_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnl_FaultBanner.ResumeLayout(false);
            this.pnl_FaultBanner.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_Auto;
        private System.Windows.Forms.Button btn_Manual;
        private System.Windows.Forms.Button btn_Overview;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_FaultBanner;
        private System.Windows.Forms.Label lbl_Alarms;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Acknowledge;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timerStatuses;
        private System.Windows.Forms.Timer timerListBox;
        private System.Windows.Forms.Button btn_ClearAll;
        private System.Windows.Forms.Timer timer_DispayMessages;
    }
}




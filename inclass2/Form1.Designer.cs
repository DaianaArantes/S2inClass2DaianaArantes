namespace inclass2
{
    partial class Form1
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
            this.buttonStop = new System.Windows.Forms.Button();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.radioButtonAM = new System.Windows.Forms.RadioButton();
            this.radioButtonPM = new System.Windows.Forms.RadioButton();
            this.labelTimer = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxAlarm = new System.Windows.Forms.CheckBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(301, 26);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 65);
            this.buttonStop.TabIndex = 0;
            this.buttonStop.Text = "Stop Alarm";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // radioButtonAM
            // 
            this.radioButtonAM.AutoSize = true;
            this.radioButtonAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAM.Location = new System.Drawing.Point(6, 11);
            this.radioButtonAM.Name = "radioButtonAM";
            this.radioButtonAM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonAM.Size = new System.Drawing.Size(53, 24);
            this.radioButtonAM.TabIndex = 2;
            this.radioButtonAM.TabStop = true;
            this.radioButtonAM.Text = "AM";
            this.radioButtonAM.UseVisualStyleBackColor = true;
            // 
            // radioButtonPM
            // 
            this.radioButtonPM.AutoSize = true;
            this.radioButtonPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPM.Location = new System.Drawing.Point(57, 11);
            this.radioButtonPM.Name = "radioButtonPM";
            this.radioButtonPM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonPM.Size = new System.Drawing.Size(52, 24);
            this.radioButtonPM.TabIndex = 3;
            this.radioButtonPM.TabStop = true;
            this.radioButtonPM.Text = "PM";
            this.radioButtonPM.UseVisualStyleBackColor = true;
            // 
            // labelTimer
            // 
            this.labelTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(57, 26);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(198, 54);
            this.labelTimer.TabIndex = 4;
            this.labelTimer.Text = "Timer";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonAM);
            this.groupBox1.Controls.Add(this.radioButtonPM);
            this.groupBox1.Location = new System.Drawing.Point(146, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 41);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxAlarm
            // 
            this.checkBoxAlarm.AutoSize = true;
            this.checkBoxAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAlarm.Location = new System.Drawing.Point(41, 172);
            this.checkBoxAlarm.Name = "checkBoxAlarm";
            this.checkBoxAlarm.Size = new System.Drawing.Size(102, 24);
            this.checkBoxAlarm.TabIndex = 6;
            this.checkBoxAlarm.Text = "Alarm On";
            this.checkBoxAlarm.UseVisualStyleBackColor = true;
            this.checkBoxAlarm.Click += new System.EventHandler(this.checkBoxAlarm_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.Red;
            this.labelMessage.Location = new System.Drawing.Point(12, 208);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(376, 37);
            this.labelMessage.TabIndex = 7;
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Items.AddRange(new object[] {
            "2:17",
            "1:00",
            "1:05",
            "1:10",
            "1:15",
            "1:20",
            "1:25",
            "1:30",
            "1:35",
            "1:40",
            "1:45",
            "1:50",
            "1:55",
            "2:00",
            "2:05",
            "2:10",
            "2:15",
            "2:20",
            "2:25",
            "2:30",
            "2:35",
            "2:40",
            "2:45",
            "2:50",
            "2:55",
            "3:00",
            "3:05",
            "3:10",
            "3:15",
            "3:20",
            "3:25",
            "3:30",
            "3:35",
            "3:40",
            "3:45",
            "3:50",
            "3:55",
            "4:00",
            "4:05",
            "4:10",
            "4:15",
            "4:20",
            "4:25",
            "4:30",
            "4:35",
            "4:40",
            "4:45",
            "4:50",
            "4:55",
            "5:00",
            "5:05",
            "5:10",
            "5:15",
            "5:20",
            "5:25",
            "5:30",
            "5:35",
            "5:40",
            "5:45",
            "5:50",
            "5:55",
            "6:00",
            "6:05",
            "6:10",
            "6:15",
            "6:20",
            "6:25",
            "6:30",
            "6:35",
            "6:40",
            "6:45",
            "6:50",
            "6:55",
            "7:00",
            "7:05",
            "7:10",
            "7:15",
            "7:20",
            "7:25",
            "7:30",
            "7:35",
            "7:40",
            "7:45",
            "7:50",
            "7:55",
            "8:00",
            "8:05",
            "8:10",
            "8:15",
            "8:20",
            "8:25",
            "8:30",
            "8:35",
            "8:40",
            "8:45",
            "8:50",
            "8:55",
            "9:00",
            "9:05",
            "9:10",
            "9:15",
            "9:20",
            "9:25",
            "9:30",
            "9:35",
            "9:40",
            "9:45",
            "9:50",
            "9:55",
            "10:00",
            "10:05",
            "10:10",
            "10:15",
            "10:20",
            "10:25",
            "10:30",
            "10:35",
            "10:40",
            "10:45",
            "10:50",
            "10:55",
            "11:00",
            "11:05",
            "11:10",
            "11:15",
            "11:20",
            "11:25",
            "11:30",
            "11:35",
            "11:40",
            "11:45",
            "11:50",
            "11:55",
            "12:00",
            "12:05",
            "12:10",
            "12:15",
            "12:20",
            "12:25",
            "12:30",
            "12:35",
            "12:40",
            "12:45",
            "12:50",
            "12:55"});
            this.comboBoxTime.Location = new System.Drawing.Point(19, 132);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTime.TabIndex = 8;
            this.comboBoxTime.Text = "Time ?";
            // 
            // label1
            // 
            this.label1.Image = global::inclass2.Properties.Resources.Clock_PNG;
            this.label1.Location = new System.Drawing.Point(288, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 84);
            this.label1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(400, 271);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTime);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.checkBoxAlarm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.buttonStop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.RadioButton radioButtonAM;
        private System.Windows.Forms.RadioButton radioButtonPM;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxAlarm;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.Label label1;
    }
}


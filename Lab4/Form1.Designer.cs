﻿namespace Lab4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxRejectionProcent = new System.Windows.Forms.TextBox();
            this.textBoxQueue1AvrLength = new System.Windows.Forms.TextBox();
            this.textBoxQueue1AvrTimeAsReal = new System.Windows.Forms.TextBox();
            this.textBoxQueue1AvrTime = new System.Windows.Forms.TextBox();
            this.textBoxDevice1Loading = new System.Windows.Forms.TextBox();
            this.textBoxDevice2Loading = new System.Windows.Forms.TextBox();
            this.textBoxDevice3Loading = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(299, 327);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(126, 47);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(690, 327);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(126, 47);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Time";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(155, 397);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(18, 20);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rejection Procent";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Queue 1 Avr Length";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(665, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 10;
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Queue 1 Avr Time AsReal(use timer for this)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(665, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 12;
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 509);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(278, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Queue 1 Avr Time(use book\'s formula)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(665, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 14;
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(618, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Device 1 Loading";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(618, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Device 3 Loading";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(618, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Device 2 Loading";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxRejectionProcent
            // 
            this.textBoxRejectionProcent.Enabled = false;
            this.textBoxRejectionProcent.Location = new System.Drawing.Point(211, 450);
            this.textBoxRejectionProcent.Name = "textBoxRejectionProcent";
            this.textBoxRejectionProcent.Size = new System.Drawing.Size(164, 26);
            this.textBoxRejectionProcent.TabIndex = 18;
            // 
            // textBoxQueue1AvrLength
            // 
            this.textBoxQueue1AvrLength.Enabled = false;
            this.textBoxQueue1AvrLength.Location = new System.Drawing.Point(211, 505);
            this.textBoxQueue1AvrLength.Name = "textBoxQueue1AvrLength";
            this.textBoxQueue1AvrLength.Size = new System.Drawing.Size(164, 26);
            this.textBoxQueue1AvrLength.TabIndex = 19;
            // 
            // textBoxQueue1AvrTimeAsReal
            // 
            this.textBoxQueue1AvrTimeAsReal.Enabled = false;
            this.textBoxQueue1AvrTimeAsReal.Location = new System.Drawing.Point(756, 444);
            this.textBoxQueue1AvrTimeAsReal.Name = "textBoxQueue1AvrTimeAsReal";
            this.textBoxQueue1AvrTimeAsReal.Size = new System.Drawing.Size(164, 26);
            this.textBoxQueue1AvrTimeAsReal.TabIndex = 20;
            // 
            // textBoxQueue1AvrTime
            // 
            this.textBoxQueue1AvrTime.Enabled = false;
            this.textBoxQueue1AvrTime.Location = new System.Drawing.Point(756, 503);
            this.textBoxQueue1AvrTime.Name = "textBoxQueue1AvrTime";
            this.textBoxQueue1AvrTime.Size = new System.Drawing.Size(164, 26);
            this.textBoxQueue1AvrTime.TabIndex = 21;
            // 
            // textBoxDevice1Loading
            // 
            this.textBoxDevice1Loading.Enabled = false;
            this.textBoxDevice1Loading.Location = new System.Drawing.Point(843, 206);
            this.textBoxDevice1Loading.Name = "textBoxDevice1Loading";
            this.textBoxDevice1Loading.Size = new System.Drawing.Size(164, 26);
            this.textBoxDevice1Loading.TabIndex = 25;
            // 
            // textBoxDevice2Loading
            // 
            this.textBoxDevice2Loading.Enabled = false;
            this.textBoxDevice2Loading.Location = new System.Drawing.Point(843, 130);
            this.textBoxDevice2Loading.Name = "textBoxDevice2Loading";
            this.textBoxDevice2Loading.Size = new System.Drawing.Size(164, 26);
            this.textBoxDevice2Loading.TabIndex = 26;
            // 
            // textBoxDevice3Loading
            // 
            this.textBoxDevice3Loading.Enabled = false;
            this.textBoxDevice3Loading.Location = new System.Drawing.Point(843, 64);
            this.textBoxDevice3Loading.Name = "textBoxDevice3Loading";
            this.textBoxDevice3Loading.Size = new System.Drawing.Size(164, 26);
            this.textBoxDevice3Loading.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(519, 233);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 556);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxDevice3Loading);
            this.Controls.Add(this.textBoxDevice2Loading);
            this.Controls.Add(this.textBoxDevice1Loading);
            this.Controls.Add(this.textBoxQueue1AvrTime);
            this.Controls.Add(this.textBoxQueue1AvrTimeAsReal);
            this.Controls.Add(this.textBoxQueue1AvrLength);
            this.Controls.Add(this.textBoxRejectionProcent);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Lab4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxRejectionProcent;
        private System.Windows.Forms.TextBox textBoxQueue1AvrLength;
        private System.Windows.Forms.TextBox textBoxQueue1AvrTimeAsReal;
        private System.Windows.Forms.TextBox textBoxQueue1AvrTime;
        private System.Windows.Forms.TextBox textBoxDevice1Loading;
        private System.Windows.Forms.TextBox textBoxDevice2Loading;
        private System.Windows.Forms.TextBox textBoxDevice3Loading;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


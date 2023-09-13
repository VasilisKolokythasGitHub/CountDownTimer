namespace CountDown
{
    partial class CountDownTimer
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
            this.label1 = new System.Windows.Forms.Label();
            this.timerlabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.inputMinutes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 32F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(801, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "Count Down Timer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timerlabel
            // 
            this.timerlabel.Font = new System.Drawing.Font("Arial Narrow", 32F);
            this.timerlabel.ForeColor = System.Drawing.Color.White;
            this.timerlabel.Location = new System.Drawing.Point(-1, 185);
            this.timerlabel.Name = "timerlabel";
            this.timerlabel.Size = new System.Drawing.Size(801, 88);
            this.timerlabel.TabIndex = 1;
            this.timerlabel.Text = "45 minutes";
            this.timerlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timerlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.White;
            this.resetButton.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(263, 276);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(118, 69);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.White;
            this.stopButton.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(423, 276);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(118, 69);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.White;
            this.startButton.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(263, 369);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(278, 69);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(801, 47);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter the minutes:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inputMinutes
            // 
            this.inputMinutes.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputMinutes.Location = new System.Drawing.Point(314, 155);
            this.inputMinutes.Multiline = true;
            this.inputMinutes.Name = "inputMinutes";
            this.inputMinutes.Size = new System.Drawing.Size(180, 36);
            this.inputMinutes.TabIndex = 7;
            this.inputMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CountDownTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(815, 477);
            this.Controls.Add(this.inputMinutes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.timerlabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CountDownTimer";
            this.Text = "Count Down Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timerlabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputMinutes;
    }
}


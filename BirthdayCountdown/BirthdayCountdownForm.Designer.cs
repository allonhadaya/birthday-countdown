namespace BirthdayCountdown
{
    partial class BirthdayCountdownForm
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.countdownLabel = new System.Windows.Forms.Label();
            this.labelUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.CustomFormat = "";
            this.birthdayPicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.birthdayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdayPicker.Location = new System.Drawing.Point(0, 0);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(324, 20);
            this.birthdayPicker.TabIndex = 0;
            this.birthdayPicker.ValueChanged += new System.EventHandler(this.birthdayPicker_ValueChanged);
            // 
            // countdownLabel
            // 
            this.countdownLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countdownLabel.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel.Location = new System.Drawing.Point(0, 20);
            this.countdownLabel.Name = "countdownLabel";
            this.countdownLabel.Size = new System.Drawing.Size(324, 47);
            this.countdownLabel.TabIndex = 1;
            this.countdownLabel.Text = "pick your birthday";
            this.countdownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUpdateTimer
            // 
            this.labelUpdateTimer.Enabled = true;
            this.labelUpdateTimer.Interval = 1000;
            this.labelUpdateTimer.Tick += new System.EventHandler(this.labelUpdateTimer_Tick);
            // 
            // BirthdayCountdownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 67);
            this.Controls.Add(this.countdownLabel);
            this.Controls.Add(this.birthdayPicker);
            this.Name = "BirthdayCountdownForm";
            this.Text = "Birthday Countdown";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private System.Windows.Forms.Label countdownLabel;
        private System.Windows.Forms.Timer labelUpdateTimer;

    }
}


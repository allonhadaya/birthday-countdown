using System;
using System.Windows.Forms;

namespace BirthdayCountdown
{
    public partial class BirthdayCountdownForm : Form
    {
        private DateTime? Birthday;

        private TimeSpan? TimeUntilBirthday
        {
            get
            {
                if (Birthday.HasValue) {
                    return Birthday.Value - DateTime.Now;
                }
                return null;
            }
        }

        private bool BirthdayHasPassed
        {
            get
            {
                return
                    TimeUntilBirthday.HasValue &&
                    TimeUntilBirthday.Value.CompareTo(TimeSpan.Zero) < 1;
            }
        }

        public BirthdayCountdownForm()
        {
            InitializeComponent();
        }

        private void birthdayPicker_ValueChanged(object sender, EventArgs e)
        {
            Birthday = birthdayPicker.Value.Date;
            UpdateCountdownLabel();
        }

        private void labelUpdateTimer_Tick(object sender, EventArgs e)
        {
            UpdateCountdownLabel();
        }

        private void UpdateCountdownLabel()
        {
            if (BirthdayHasPassed) {
                countdownLabel.Text = "happy birthday!";
            } else if (Birthday.HasValue) {
                countdownLabel.Text = string.Format(@"{0:%d} days {0:hh\:mm\:ss}", TimeUntilBirthday);
            } else {
                countdownLabel.Text = "pick your birthday";
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace BirthdayCounter
{
    public partial class BirthdayCountdownForm : Form
    {
        private DateTime? Birthday;

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
            if (Birthday.HasValue) {
                countdownLabel.Text = (Birthday.Value - DateTime.Now).ToString(@"d\ \d\a\y\s\ h\:m\:ss");
            } else {
                countdownLabel.Text = "pick your birthday";
            }
        }
    }
}

using System.Text.RegularExpressions;

namespace hm3_BirtdayCalendar
{
    public partial class BirtdayCalendarForm : Form
    {
        public BirtdayCalendarForm()
        {
            InitializeComponent();

            foreach (TextBox el in InputDateGroupBox.Controls.OfType<TextBox>())
            {
                el.KeyPress += El_KeyPress; ;
            }
        }

        private void El_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ShowBirtDayButton_Click(object sender, EventArgs e)
        {
            string yearText = InputYearTextBox.Text;
            string monthText = InputMonthTextBox.Text;
            string dayText = InputDayTextBox.Text;

            if (!IsValidInput(yearText, monthText, dayText))
            {
                MessageBox.Show("Incorrect data. Please enter the correct date for year, month and day.");
                return;
            }

            int year = int.Parse(yearText);
            int month = int.Parse(monthText);
            int day = int.Parse(dayText);

            if (IsValidDate(year, month, day))
            {
                DateTime birthday = new DateTime(year, month, day);
                MonthCalendar.SelectionStart = birthday;
                MonthCalendar.SelectionEnd = birthday;
            }
            else
            {
                MessageBox.Show("Incorrect birth date. Please enter valid date.");
            }
        }

        private bool IsValidInput(string yearText, string monthText, string dayText)
        {
            string pattern = @"^\d+$";

            return Regex.IsMatch(yearText, pattern) &&
                   Regex.IsMatch(monthText, pattern) &&
                   Regex.IsMatch(dayText, pattern);
        }

        private bool IsValidDate(int year, int month, int day)
        {
            if (year >= DateTime.MinValue.Year &&
                year <= DateTime.MaxValue.Year &&
                month >= 1 && month <= 12)
            {
                int maxDay = DateTime.DaysInMonth(year, month);
                return day >= 1 && day <= maxDay;
            }
            return false;
        }
    }
}
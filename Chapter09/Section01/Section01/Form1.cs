using System.Globalization;

namespace Section01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            DateTime date = dtpDate.Value;
            tbOut.Text = date.AddDays((double)nmudDay.Value).ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {

        }

        private void btBirthCulc_Click_1(object sender, EventArgs e) {
            DateTime birth = dtpBirth.Value;  //生まれた日付
            DateTime today = DateTime.Today; //今日の日付

            TimeSpan timeSpan = today.Date - birth.Date;
            tbOut.Text = $"あなたは{GetAge(birth, today)}歳です";
            tbOut2.Text = $"生まれてから{timeSpan.Days}日経過";
            tbOut3.Text = $"生まれた{birth.Month}月{birth.Day}日は第{NthWeek(birth)}週の{birth.ToString("dddd")}です";
        }

        static int NthWeek(DateTime date) {
            var firstDay = new DateTime(date.Year, date.Month, 1);
            var firstDayOfWeek = (int)(firstDay.DayOfWeek);
            return (date.Day + firstDayOfWeek - 1) / 7 + 1;
        }

        //年齢を求めるメソッド
        static int GetAge(DateTime birthday, DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if(targetDay < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }

        static int GetNextBirth(DateTime day, DateTime birth) {
            var nextbirthday = new DateTime(day.Year, birth.Month, birth.Day);
            if(nextbirthday < day.Date) {
                nextbirthday = nextbirthday.AddYears(1);
            }
            return (nextbirthday - day.Date).Days;
        }

        private void dtpBirth2_ValueChanged(object sender, EventArgs e) {

        }

        private void btBirthCulc2_Click(object sender, EventArgs e) {
            DateTime day = dtpBirth2.Value;
            DateTime birth = dtpBirth.Value;
            tbOut4.Text = $"{GetNextBirth(day,birth)}";
        }

        private void label4_Click(object sender, EventArgs e) {

        }
    }
}

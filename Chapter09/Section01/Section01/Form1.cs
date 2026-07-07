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
            tbOut.Text = $"あなたは{GetAge(birth,today)}歳です";
            tbOut2.Text = $"生まれてから{timeSpan.Days}日経過";
        }

        //年齢を求めるメソッド
        static int GetAge(DateTime birthday, DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if(targetDay < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }
    }
}

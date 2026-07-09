using System.Globalization;

namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btButton1_Click(object sender, EventArgs e) {
            DateTime now = DateTime.Now;
            tbOut1.Text = $"{now.ToString("d")} {now.ToString("t")}";
        }

        private void btButton2_Click(object sender, EventArgs e) {
            DateTime now = DateTime.Now;
            tbOut2.Text = $"{now.ToString("D")} {now.ToString("HHŽžmm•ªss•b")}";
        }

        private void btButton3_Click(object sender, EventArgs e) {
            DateTime now = DateTime.Now;
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            tbOut3.Text = $"{now.ToString("gg y”N MŒŽ d“ú",culture)}({now.ToString("dddd")})";
        }
    }
}

using System.Diagnostics;
using System.Drawing.Text;
using System.Globalization;

namespace Exercise01 {
    public partial class Form1 : Form {
        Stopwatch sw = new Stopwatch();
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
            tbOut3.Text = $"{now.ToString("gg y”N MŒŽ d“ú", culture)}({now.ToString("dddd")})";
        }

        private void btStart_Click(object sender, EventArgs e) {
            sw.Start();
            timer1.Start();
        }

        private void btStop_Click(object sender, EventArgs e) {
            sw.Stop();
            timer1.Stop();
            tbOut4.Text = $"{sw.Elapsed}";
        }

        private void timer1_Tick(object sender, EventArgs e) {
            tbOut4.Text = $"{sw.Elapsed}";
        }

        private void btReset_Click(object sender, EventArgs e) {
            sw.Reset();
            tbOut4.Text = $"{sw.Elapsed}";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            listBox1.Items.Insert(0, tbOut4.Text);
        }
    }

    /*internal class TimeWatch {
        private DateTime _time;

        public void Start() {
            _time = DateTime.Now;
        }

        public TimeSpan Stop() {
            return DateTime.Now - _time;
        }
    }*/
}

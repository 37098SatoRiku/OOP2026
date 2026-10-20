using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Windows;

namespace Exercise01_WPF {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e) {
            var ofd = new OpenFileDialog();
            if(ofd.ShowDialog() is true) {
                TextArea.Text = await TextReaderSample.ReadTextAsync(ofd.FileName);
            }
        }
    }

    //非同期のファイル読み込み処理
    internal class TextReaderSample {
        public static async Task<string> ReadTextAsync(string fileName) {
            var sb = new StringBuilder();

            //ここに非同期でテキストファイルを読み込む処理を記述する
            using var sr = new StreamReader(fileName);
            string? line;
            while((line = await sr.ReadLineAsync()) != null) {
                sb.AppendLine(line);
            }

            return sb.ToString();
        }
    }
}
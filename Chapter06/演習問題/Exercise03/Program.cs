using System.Text;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";
            #region
            Console.WriteLine("6.3.1");
            Exercise1(text);

            Console.WriteLine("6.3.2");
            Exercise2(text);

            Console.WriteLine("6.3.3");
            Exercise3(text);

            Console.WriteLine("6.3.4");
            Exercise4(text);

            Console.WriteLine("6.3.5");
            Exercise5(text);

            Console.WriteLine("6.3.6");
            Exercise6(text);
            #endregion
        }

        private static void Exercise1(string text) {
            Console.WriteLine("空白の数:" + text.Count(c => c == ' '));
        }

        private static void Exercise2(string text) {
            Console.WriteLine(text.Replace("big", "small"));            
        }

        private static void Exercise3(string text) {
            var sb = new StringBuilder();
            foreach(var word in text.Split(' ')) {
                Console.WriteLine(sb.Append(word + ' '));
            }
        }

        private static void Exercise4(string text) {
            Console.WriteLine("単語の数:" + text.Split(' ').Length);
        }

        private static void Exercise5(string text) {
            Console.WriteLine("4文字以下の単語\n" + string.Join(",",text.Split(' ').Where(w => w.Length <= 4)));
            
        }

        //アルファベットの数を表示する
        private static void Exercise6(string text) {
            var dict = new Dictionary<char, int>();
            foreach(char c in text) {
                ;
            }
        }
    }
}

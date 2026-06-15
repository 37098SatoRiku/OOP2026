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
                sb.Append(word + ' ');
            }
            Console.WriteLine(sb.ToString().TrimEnd() + ':');
        }

        private static void Exercise4(string text) {
            Console.WriteLine("単語の数:" + text.Split(' ').Length);
        }

        private static void Exercise5(string text) {
            Console.WriteLine("4文字以下の単語\n" + string.Join(",", text.Split(' ').Where(w => w.Length <= 4)));

        }

        
        private static void Exercise6(string text) {
            //アルファベットの数を表示する
            /*var dict = new SortedDictionary<char, int>();
            foreach(char c in text.ToLower().Replace(" ", "")) {
                if(dict.ContainsKey(c)) {
                    dict[c]++;    //登録されている場合
                } else {
                    dict[c] = 1;  //未登録の場合
                }
            }
            foreach(var result in dict) {
                Console.WriteLine($"{result.Key} = {result.Value}");
            }*/




            /*ディクショナリを使った集計
            var alphDicCount = Enumerable.Range('a', 26).ToDictionary(num => ((char)num), num => 0);
            foreach(var c in text.ToLower().Replace(" ", "")) {
                alphDicCount[c]++;
            }
            foreach(var word in alphDicCount) {
                Console.WriteLine($"{word.Key} = {word.Value}");
            }*/




            /*配列を用いた集計
            var array = Enumerable.Repeat(0, 26).ToArray();
            foreach(var alph in text.ToLower().Replace(" ", "")) {
                array[alph - 'a']++;
            }
            for(char ch = 'a'; ch <= 'z'; ch++) {
                Console.WriteLine($"{ch}:{array[ch - 'a']}");
            }*/




            //aから順にカウント
            for(char ch = 'a'; ch <='z'; ch++) {
                Console.WriteLine($"{ch}:{text.ToLower().Replace(" ","").Count(c => c == ch)}");
            }

        }
    }
}
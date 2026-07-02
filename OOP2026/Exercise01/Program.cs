
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";

            Console.WriteLine("問題8.1.1");
            Exercise01(text);
            Console.WriteLine();
            Console.WriteLine("問題8.1.2");
            Exercise02(text);
        }

        private static void Exercise01(string text) {
            var dict = new SortedDictionary<char, int>();
            for(int i = 0; i < text.Length; i++) {
                var ch = text.ToUpper()[i];
                if('A' <= ch && ch <= 'Z') {
                    if(dict.ContainsKey(ch)) {
                        dict[ch]++;
                    } else {
                        dict[ch] = 1;
                    }
                }
            }
            foreach(var result in dict) {
                Console.WriteLine($"{result.Key}:{result.Value}");
            }
        }

        private static void Exercise02(string text) {

        }
    }
}

using System.Text;

namespace Section05 {
    internal class Program {
        static void Main(string[] args) {
            var sb = new StringBuilder();
            foreach(var word in string.Join(",", Getword())) {
                sb.Append(word);
            }
            Console.WriteLine(sb);
        }

        private static IEnumerable<string> Getword() {
            return ["Orange", "Lemon", "Strawberry"];
        }
    }
}

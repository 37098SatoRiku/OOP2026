
using System.Diagnostics.SymbolStore;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            List<string> langs = [
               "C#","Java","Ruby","PHP","Python","TypeScript","JavaScript","Swift","Go"
            ];

            Exercise1(langs);
            Console.WriteLine("---");
            Exercise2(langs);
            Console.WriteLine("---");
            Exercise3(langs);
        }

        private static void Exercise1(List<string> langs) {
            //foreach文
            Console.WriteLine("foreach文で出力");
            foreach(string lang in langs) {
                if(lang.Contains('S')) {
                    Console.WriteLine(lang);
                }
            }


            //for文
            Console.WriteLine("\nfor文で出力");
            for(int n = 0; n < langs.Count; n++) {
                if(langs[n].Contains('S')) {
                    Console.WriteLine(langs[n]);
                }
            }


            //while文
            Console.WriteLine("\nwhile文で出力");
            int i = 0;
            while(i < langs.Count) {
                if(langs[i].Contains('S')) {
                    Console.WriteLine(langs[i]);
                }
                i++;
            }
        }

        private static void Exercise2(List<string> langs) {
            var result = langs.Where(s => s.Contains('S'));
            foreach(var name in result) {
                Console.WriteLine(name);
            }
        }

        private static void Exercise3(List<string> langs) {
            var name = langs.Find(n => n.Length == 10);
            if(name is null) {
                name = "unknown";
            }
            Console.WriteLine(name);
        }
    }
}

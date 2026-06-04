using Exercise01;
namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {


            // 5.2.1
            var ymCollection = new YearMonth[] {
                new YearMonth(1980, 1),
                new YearMonth(1990, 4),
                new YearMonth(2000, 7),
                new YearMonth(2010, 9),
                new YearMonth(2024, 12),
            };

            Console.WriteLine("5.2.2");
            Exercise2(ymCollection);

            Console.WriteLine("5.2.4");
            Console.WriteLine(Exercise4(ymCollection)?.ToString()??"21世紀のデータはありません。");

            Console.WriteLine("5.2.5");
            Exercise5(ymCollection);
        }

        private static void Exercise2(YearMonth[] ymCollection) {
            foreach(var item in ymCollection) {
                Console.WriteLine(item);
            }
        }

        private static YearMonth? Exercise4(YearMonth[] ymCollection) {
            return ymCollection.FirstOrDefault(item => item.Is21Century());
        }


        private static void Exercise5(YearMonth[] ymCollection) {
            YearMonth[] result = ymCollection.Select(x => x.AddOneMonth()).ToArray();
            foreach(var item in result) {
                Console.WriteLine(item);
            }
        }
    }
}

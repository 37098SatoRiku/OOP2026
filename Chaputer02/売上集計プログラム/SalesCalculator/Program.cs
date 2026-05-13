
namespace SalesCalculator {
    internal class Program {
        static void Main(string[] args) {

            var sales = new SalesCounter(@"data\sales.csv");
            var amountPerStore = sales.GetPerStoreSales();
            foreach(var obj in amountPerStore) {
                Console.WriteLine($"{obj.Key}{obj.Value}");
            }

            var sales1 = new SalesCounter(@"data\sales.csv");
            var amountPerProductCategory = sales.GetPerCategorySales();
            foreach(var obj in amountPerProductCategory) {
                Console.WriteLine($"{obj.Key}{obj.Value}");
            }
        }
    }
}

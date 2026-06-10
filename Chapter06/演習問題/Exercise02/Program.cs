namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("整数文字列:");
            if(int.TryParse(Console.ReadLine(),out var number)) {
                Console.WriteLine(number.ToString("#,0"));
            } else {
                Console.WriteLine("整数文字列ではありません");
            }
        }
    }
}

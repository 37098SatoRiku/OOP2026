namespace Sanple0413
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("表示回数:");
            string? inputNum = Console.ReadLine(); //入力

            int count = int.Parse(inputNum);
            int i = 0;

            while (count > i )
            {
                if ((i + 1) % 2 == 0){
                    Console.WriteLine((i + 1) + ":Hello!");   //画面出力
                }
             i++;
            }
        }
    }
}

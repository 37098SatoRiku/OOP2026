namespace Sample0415
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)  //入力
            {
                Console.Write("array[" + i + "] = ");
                array[i] = int.Parse(Console.ReadLine());
            }

            //for (int i = 0; i < array.Length; i++)　//集計
            //{
            //    sum += array[i];
            //}

            for (int i = 0; i < array.Length; i++)　//出力
            {
                Console.Write("array[" + i + "]:");
                astOut(array[i]);
            }
            Console.WriteLine("合計:" + array.Where(n => n % 2 == 0).Sum());  //合計を出力
            astOut(array.Sum());
        }
        static void astOut(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

namespace Exercise02 {
    internal class InchConverter { 
        public static void Main(string[] args) {
            PrintInchToMeterList(1, 10);
        }

        //インチからメートルを求める
        private static void PrintInchToMeterList(int v1 ,int v2) {
            for(int i = 0; i < v2; i++) {
                Console.WriteLine($"{i + 1}インチ = {((i+1) * 0.0254).ToString("0.0000")}メートル");
            }
        }
    }

}

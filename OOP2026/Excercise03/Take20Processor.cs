namespace Excercise03 {
    internal class Take20Processor : ITextFileService {
        private int _count = 0;

        public void Initialize(string fname) => _count = 0;
        public void Execute(string line) {
            _count++;
            if(_count <= 20) {
                Console.WriteLine(line);
            }
        }
        public void Terminate() => Console.WriteLine("{0}行", _count);
    }
}

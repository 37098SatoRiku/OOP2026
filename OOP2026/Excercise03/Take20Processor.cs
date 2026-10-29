namespace Excercise03 {
    internal class Take20Processor : ITextFileService {
        private int _count = 0;

        public void Initialize(string fname) => _count = 0;
        public bool Execute(string line) {
           Console.WriteLine(line);
            _count++;
            return _count >= 20;
        }
        public void Terminate() => Console.WriteLine("{0}行", _count);
    }
}

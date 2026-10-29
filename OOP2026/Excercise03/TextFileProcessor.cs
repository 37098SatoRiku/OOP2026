namespace Excercise03 {
    internal class TextFileProcessor {
        private ITextFileService _servise;
        public TextFileProcessor(ITextFileService service) {
            _servise = service;
        }

        public void Run(string fileName) {
            _servise.Initialize(fileName);
            var lines = File.ReadLines(fileName);
            foreach(var line in lines) {
                if(_servise.Execute(line)) {
                    break;
                }
            }
            _servise.Terminate();
        }
    }
}

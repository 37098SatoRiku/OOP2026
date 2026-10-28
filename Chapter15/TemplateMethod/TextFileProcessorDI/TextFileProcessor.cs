namespace TextFileProcessorDI {
    internal class TextFileProcessor {
        private ITextFileService _servise;
        public TextFileProcessor(ITextFileService service) {
            _servise = service;
        }

        public void Run(string fileName) {
            _servise.Initialize(fileName);
            var lines = File.ReadLines(fileName);
            foreach(var line in lines) {
                _servise.Execute(line);
            }
            _servise.Terminate();
        }
    }
}

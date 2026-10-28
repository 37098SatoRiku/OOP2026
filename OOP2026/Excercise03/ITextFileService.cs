namespace Excercise03 {
    internal interface ITextFileService {
        void Initialize(string fname);
        void Execute(string line);
        void Terminate();
    }
}

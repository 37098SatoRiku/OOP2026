namespace Excercise03 {
    internal interface ITextFileService {
        void Initialize(string fname);
        bool Execute(string line);
        void Terminate();
    }
}

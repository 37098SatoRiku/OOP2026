using TextFileProcessor;

string path = @"C:\Users\infosys\source\repos\OOP2026\Chapter14\Section04\Program.cs";

TextProcessor.Run<FileProgram>(path);

public class FileProgram : TextProcessor {
    private int _count = 0;
    private string? word = "";

    protected override void Initialize(string fname) {
        _count = 0;
        Console.Write("カウントしたい単語:");
        word = Console.ReadLine();
    }

    protected override void Execute(string line) => _count += line.Split(word).Length - 1;

    protected override void Terminate() => Console.WriteLine($"{word}は{_count}つ出現します");
}
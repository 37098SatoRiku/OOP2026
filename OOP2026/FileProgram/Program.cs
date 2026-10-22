using TextFileProcessor;

string path = @"C:\Users\infosys\source\repos\OOP2026\Chapter14\Section04\Program.cs";

Console.Write("カウントしたい単語:");
TextProcessor.Run<FileProgram>(path);

public class FileProgram : TextProcessor {
    private int _count = 0;
    public static string? word = Console.ReadLine();

    protected override void Initialize(string fname) => _count = 0;

    protected override void Execute(string line) => _count += line.Split(word).Length - 1;

    protected override void Terminate() => Console.WriteLine($"{word}は{_count}つ出現します");
}
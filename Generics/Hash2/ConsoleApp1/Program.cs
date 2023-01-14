using ConsoleApp1.Entities;

HashSet<LogRecord> set = new();

Console.WriteLine("Enter file full path: ");
string path = Console.ReadLine();

try {
    using StreamReader streamReader = new StreamReader(path);
    while (!streamReader.EndOfStream) {
        string[] line = streamReader.ReadLine().Split(" ");
        string name = line[0];
        DateTime instant = DateTime.Parse(line[1]);
        set.Add(new LogRecord { Username = name, Instat = instant});
    }
    Console.WriteLine($"Total users {set.Count}");
} catch (IOException error) {
    Console.WriteLine(error.Message);
}
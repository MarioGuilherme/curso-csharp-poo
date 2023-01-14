using Comparavel.Enttites;

string path = @"C:\Users\mgarodrigues\Desktop\in.txt";

try {
    using StreamReader streamReader = File.OpenText(path);
    List<Employee> list = new();
    while (!streamReader.EndOfStream)
        list.Add(new(streamReader.ReadLine()));

    list.Sort();

    foreach (Employee employee in list)
        Console.WriteLine(employee);

} catch (IOException error) {
    Console.WriteLine("An error occurred");
    Console.WriteLine(error.Message);
}
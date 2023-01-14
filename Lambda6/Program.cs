using Lambda6.Entities;
using System.Globalization;

namespace Lambda6 {
    public class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter full file path: ");
            string path = Console.ReadLine() ?? "";

            List<Product> list = new();

            using StreamReader streamReader = File.OpenText(path);
            while (!streamReader.EndOfStream) {
                string[] fields = streamReader.ReadLine()!.Split(",");
                string name = fields[0];
                double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                list.Add(new(name, price));
            }

            double average = list.Select(product => product.Price).DefaultIfEmpty(0d).Average();
            Console.WriteLine($"Average Price: {average.ToString("F2", CultureInfo.InvariantCulture)}");

            List<string> names = list.Where(product => product.Price < average)
                            .OrderByDescending(product => product.Name)
                            .Select(product => product.Name).ToList();

            foreach (string name in names)
                Console.WriteLine(name);
        }
    }
}
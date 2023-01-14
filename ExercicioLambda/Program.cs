using ExercicioLambda.Entities;
using System.Globalization;

namespace ExercicioLambda;
public class Program {
    public static void Main() {
        List<Employee> employees = new();

        Console.Write("Enter full file path: ");
        string path = Console.ReadLine() ?? "";
        
        Console.Write("Enter salary: ");
        double minSalary = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

        using StreamReader streamReader = File.OpenText(path);
        while (!streamReader.EndOfStream) {
            string[] fields = streamReader.ReadLine()!.Split(",");
            string name = fields[0];
            string email = fields[1];
            double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

            employees.Add(new(name, email, salary));
        }

        Console.WriteLine($"Email of people whose salary is more than {minSalary}:");
        List<string> emails = employees.Where(employee => employee.Salary > minSalary)
                                       .Select(employee => employee.Email)
                                       .ToList();

        foreach (string email in emails)
            Console.WriteLine(email);

        double sumNameStartsM = employees.Where(employee => employee.Name[0] == 'M')
                                         .Select(employee => employee.Salary)
                                         .Aggregate((x, y) => x + y);

        Console.WriteLine($"Sum of salary of people whose name start with 'M': {sumNameStartsM}:");
    }
}
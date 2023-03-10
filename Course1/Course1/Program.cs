using Course1.Entities;
using System.Globalization;

namespace Course {
    class Program {
        public static void Main(string[] args) {
            List<Employee> list = new();
            Console.WriteLine("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsorced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.WriteLine("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y') {
                    Console.WriteLine("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsorcedEmployee(name, hours, valuePerHour, additionalCharge));
                } else
                    list.Add(new Employee(name, hours, valuePerHour));
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");

            foreach (Employee emp in list)
                Console.WriteLine($"{emp.Name} - $ {emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
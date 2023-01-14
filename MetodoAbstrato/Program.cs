using MetodoAbstrato.Entities;
using System.Globalization;

namespace MetodoAbstrato {
    class Program {
        public static void Main(string[] args) {
            List<Taxpayer> list = new();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i') {
                    Console.Write("Health expeditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                } else {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine();
            Console.Write("TAXES PAID:");
            double totalTaxes = 0;
            foreach (Taxpayer taxpayer in list) {
                totalTaxes += taxpayer.TaxRate();
                Console.WriteLine($"{taxpayer.Name}: $ {taxpayer.TaxRate().ToString("F2", CultureInfo.InvariantCulture)}");
            }

            Console.WriteLine();
            Console.Write($"TOTAL TAXES: $ {totalTaxes}");
        }
    }
}
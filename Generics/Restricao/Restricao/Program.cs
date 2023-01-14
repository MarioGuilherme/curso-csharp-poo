using Restricao;
using System.Globalization;

List<Product> list = new();

Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++) {
    string[] vect = Console.ReadLine().Split(",");
    list.Add(new(vect[0], double.Parse(vect[1], CultureInfo.InvariantCulture)));
}

CalculationService calculationService = new();

Product max = calculationService.Max(list);

Console.Write($"Most expensive: {max}");
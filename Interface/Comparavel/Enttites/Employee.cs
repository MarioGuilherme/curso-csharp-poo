using System.Globalization;

namespace Comparavel.Enttites {
    public class Employee : IComparable {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee) {
            string[] vetor = csvEmployee.Split(",");
            Name = vetor[0];
            Salary = double.Parse(vetor[1], CultureInfo.InvariantCulture);
        }

        public override string ToString() {
            return $"{Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object? obj) {
            if (obj is not Employee)
                throw new ArgumentException("Comparing error: argument is not a Employee");

            Employee otherEmployee = obj as Employee;
            return Name.CompareTo(otherEmployee.Name);
        }
    }
}
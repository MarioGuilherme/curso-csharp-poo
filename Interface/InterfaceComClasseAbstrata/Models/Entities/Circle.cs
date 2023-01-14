using System.Globalization;

namespace InterfaceComClasseAbstrata.Models.Entities {
    public class Circle : AbstractShape {
        public double Radius { get; set; }

        public override double Area() => Math.PI * Radius * Radius;

        public override string ToString() => $"Circle color = {Color}, "
            + $"radius = {Radius.ToString("F2", CultureInfo.InvariantCulture)}"
            + $", area = {Area().ToString("F2", CultureInfo.InvariantCulture)}";
    }
}
using System.Globalization;

namespace InterfaceComClasseAbstrata.Models.Entities {
    public class Rectangle : AbstractShape {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area() => Width * Height;

        public override string ToString() => $"Rectangle color = {Color}, "
            + $"width = {Width.ToString("F2", CultureInfo.InvariantCulture)}"
            + $"heigth = {Height.ToString("F2", CultureInfo.InvariantCulture)}"
            + $", area = {Area().ToString("F2", CultureInfo.InvariantCulture)}";
    }
}
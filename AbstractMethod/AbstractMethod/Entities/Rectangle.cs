using AbstractMethod.Entities.Enums;

namespace AbstractMethod.Entities {
    class Rectangle : Shape {
        public double Width { get; set; }
        public double Heigth { get; set; }

        public Rectangle(double width, double height, Color color) : base(color) {
            Width = width;
            Heigth = height;
        }

        public override double Area() {
            return Width * Heigth;
        }
    }
}
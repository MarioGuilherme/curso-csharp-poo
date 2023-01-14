using InterfaceComClasseAbstrata.Models.Enums;
using InterfaceComClasseAbstrata.Models.Interfaces;

namespace InterfaceComClasseAbstrata.Models.Entities {
    public abstract class AbstractShape : IShape {
        public Color Color { get; set; }
        public abstract double Area();
    }
}
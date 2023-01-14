using InterfaceComClasseAbstrata.Models.Entities;
using InterfaceComClasseAbstrata.Models.Enums;
using InterfaceComClasseAbstrata.Models.Interfaces;

IShape s1 = new Circle() { Radius = 2, Color = Color.WHITE };
IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.BLACK };
Console.WriteLine(s1);
Console.WriteLine(s2);
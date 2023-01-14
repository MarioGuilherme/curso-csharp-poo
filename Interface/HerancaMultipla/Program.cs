using HerancaMultipla.Devices;

Printer printer = new() { SerialNumber = 1080 };
printer.ProcessDoc("My letter");
printer.Print("My letter");

Scanner scanner = new() { SerialNumber = 2003 };
scanner.ProcessDoc("My Email");
Console.WriteLine(scanner.Scan());

ComboDevice comboDevice = new() { SerialNumber = 3921 };
comboDevice.ProcessDoc("My dissertation");
comboDevice.Print("My dissertation");
Console.WriteLine(comboDevice.Scan());
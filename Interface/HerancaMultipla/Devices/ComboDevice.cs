namespace HerancaMultipla.Devices {
    public class ComboDevice : Device, IScanner, IPrinter {
        public void Print(string document) {
            Console.WriteLine($"ComboDevice print {document}");
        }

        public override void ProcessDoc(string document) {
            Console.WriteLine($"Combodevice processing {document}");
        }

        public string Scan() {
            return "Combodevice scan result";
        }
    }
}
using Course.Services;

delegate void BinaryNumericOperation(double n1, double n2);

class Program {
    public static void Main(string[] args) {
        List<Product> list = new() {
            new("Tv", 900.00),
            new("Mouse", 50.00),
            new("Tablet", 350.50),
            new("HD Case", 80.90)
        };

        List<string> result = list.Select(product => product.Name.ToUpper()).ToList();
        foreach (string item in result) 
            Console.WriteLine(item);
    }

    static string Upper(Product product) {
        return product.Name.ToUpper();
    }
}
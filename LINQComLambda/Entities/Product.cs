class Product {
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public Category Category { get; set; }

    public override string ToString() => "Id: " + Id + ", Name: " + Name + ", Price: " + Price + ", Category: " + Category.Tier;
}

class Util {
    public static void Print<T>(string message, IEnumerable<T> collection) {
        Console.WriteLine(message);
        foreach (var item in collection)
            Console.WriteLine(item);
        Console.WriteLine();
    } 
}
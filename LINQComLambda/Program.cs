Category category1 = new() { Id = 1, Name = "Tools", Tier = 2 };
Category category2 = new() { Id = 2, Name = "Computers", Tier = 1 };
Category category3 = new() { Id = 3, Name = "Eletronics", Tier = 1 };

List<Product> products = new() {
    new() { Id = 1, Name = "Computer", Price = 1100, Category = category2 },
    new() { Id = 2, Name = "Hammer", Price = 90, Category = category1 },
    new() { Id = 3, Name = "TV", Price = 1700, Category = category3 },
    new() { Id = 4, Name = "Notebook", Price = 1300, Category = category2 },
    new() { Id = 5, Name = "Saw", Price = 80, Category = category1 },
    new() { Id = 6, Name = "Tablet", Price = 700, Category = category2 },
    new() { Id = 7, Name = "Camera", Price = 700, Category = category3},
    new() { Id = 8, Name = "Printer", Price = 350, Category = category3 },
    new() { Id = 9, Name = "Macbook", Price = 1800, Category = category2 },
    new() { Id = 10, Name = "Sound Bar", Price = 700, Category = category3 },
    new() { Id = 11, Name = "Level", Price = 70, Category = category1 }
};

//var result1 = products.Where(product => product.Category.Tier == 1 && product.Price < 900);
var result1 = from p in products
              where p.Category.Tier == 1 && p.Price < 900d
              select p;
Util.Print("TIER AND PRICE < 900:", result1);

//var result2 = products.Where(product => product.Category.Name.Equals("Tools")).Select(product => product.Name);
var result2 = from p in products
              where p.Category.Name == "Tools"
              select p.Name;
Util.Print("NAMES OF PRODUCTS FROM TOOLS:", result2);

//var result3 = products.Where(product => product.Name[0] == 'C').Select(product => new { product.Name, product.Price, CategoryName = product.Category.Name });
var result3 = from p in products
              where p.Name[0] == 'C'
              select new {
                  p.Name,
                  p.Price,
                  CategoryNmae = p.Category.Name
              };
Util.Print("NAMES STARTED WIT 'C' AND ANONYMOUS OBJECT:", result3);

//var result4 = products.Where(product => product.Category.Tier == 1).OrderBy(product => product.Price).ThenBy(product => product.Name);
var result4 = from p in products
              where p.Category.Tier == 1
              orderby p.Name
              orderby p.Price
              select p;
Util.Print("TIER 1 ORDER BY PRICE THEN BY NAME:", result4);

var result5 = (from p in result4
               select p).Skip(2).Take(4);
Util.Print("TIER 1 ORDER BY PRUCE THEN BY NAME SKIP 2 TAKE 4", result5);

var result6 = products.FirstOrDefault();
Console.WriteLine("First or default teste1: " + result6);

var result7 = products.Where(product => product.Price > 3000).FirstOrDefault();
Console.WriteLine("First or default teste2: " + result7);

var result8 = products.Where(product => product.Id == 3).SingleOrDefault();
Console.WriteLine("Single or default teste1: " + result8);

var result9 = products.Where(product => product.Id == 30).SingleOrDefault();
Console.WriteLine("Single or default teste9: " + result9);

var result10 = products.Max(product => product.Price);
Console.WriteLine("Max Price: " + result10);

var result11 = products.Min(product => product.Price);
Console.WriteLine("Min Price: " + result11);

var result12 = products.Where(product => product.Category.Id == 1).Sum(product => product.Price);
Console.WriteLine("Category 1 Sum Prices: " + result12);

var result13 = products.Where(product => product.Category.Id == 1).Average(product => product.Price);
Console.WriteLine("Category 1 Average Prices: " + result13);

var result14 = products.Where(product => product.Category.Id == 5).Select(product => product.Price).DefaultIfEmpty(0).Average();
Console.WriteLine("Category 5 Average Prices: " + result14);

var result15 = products.Where(product => product.Category.Id == 5).Select(product => product.Price).Aggregate(0d, (x, y) => x + y);
Console.WriteLine("Category 1 Aggregate Sum: " + result15);
Console.WriteLine();

//var result16 = products.GroupBy(product => product.Category);
var result16 = from p in products
               group p by p.Category;
foreach (IGrouping<Category, Product> group in result16) {
    Console.WriteLine("Category " + group.Key.Name + ":");
    foreach (Product product in group)
        Console.WriteLine(product);
    Console.WriteLine();
}
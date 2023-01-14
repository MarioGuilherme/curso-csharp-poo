// Data Source
int[] numbers = new int[] { 2, 3, 4, 5 };

// Query expression
var result = numbers
    .Where(number => number % 2 == 0)
    .Select(number => number * 10);

// Execute
foreach (var number in result)
    Console.WriteLine(number);
using BankException.Entitites;
using BankException.Exception;

namespace BankException {
    class Program {
        static void Main(string[] args) {
            try {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine());

                Console.Write("Withdraw limit: ");
                double withDrawLimit = double.Parse(Console.ReadLine());

                Account account = new() {
                    Number = number,
                    Balance = initialBalance,
                    Holder = holder,
                    WithDrawLimit = withDrawLimit
                };

                Console.Write("Enter amount for withdraw: ");
                double withDrawQuantity = double.Parse(Console.ReadLine());
                account.WithDraw(withDrawQuantity);

                Console.Write($"New balance: {account.Balance}");
            } catch (DomainException e) {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
        }
    }
}
namespace SolucaoSemInterface.Services {
    public class BrazilTaxService : ITaxService {
        public double Tax(double amount) {
            if (amount <= 100)
                return amount * .2;

            return amount * .15;
        }
    }
}
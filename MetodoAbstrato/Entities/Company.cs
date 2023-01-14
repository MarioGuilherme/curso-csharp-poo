namespace MetodoAbstrato.Entities {
    class Company : Taxpayer {
        public int NumberOfEmployees { get; set; }

        public Company() {}

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome) {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double TaxRate() {
            return NumberOfEmployees > 10 ? AnualIncome * 0.14 : AnualIncome * 0.16;
        }
    }
}
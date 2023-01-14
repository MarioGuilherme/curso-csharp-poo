namespace BankException.Exception {
    class DomainException : ApplicationException {
        public DomainException(string message) : base(message) {}
    }
}
namespace ExercicioInterface.Entities {
    public class Installment {
        private DateTime _dueDate { get; set; }
        private double _amount { get; set; }

        public Installment(DateTime dueDate, double amount) {
            _dueDate = dueDate;
            _amount = amount;
        }
    }
}
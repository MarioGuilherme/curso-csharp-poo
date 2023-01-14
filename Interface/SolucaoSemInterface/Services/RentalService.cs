﻿using SolucaoSemInterface.Entities;

namespace SolucaoSemInterface.Services {
    public class RentalService {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        private ITaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService) {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental) {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment;
            basicPayment = duration.TotalHours <= 12
                ? PricePerHour * Math.Ceiling(duration.TotalHours)
                : PricePerDay * Math.Ceiling(duration.TotalDays);

            double tax = _taxService.Tax(basicPayment);
            carRental.Invoice = new(basicPayment, tax);
        }
    }
}
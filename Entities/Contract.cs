using System;
using ExercicioInterface.Entities;
using System.Collections.Generic;

namespace ExercicioInterface.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> _installment;

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            _installment = new List<Installment>();
        }
    }
}

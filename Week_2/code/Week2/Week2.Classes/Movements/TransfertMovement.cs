using System;
using System.Collections.Generic;
using System.Text;

namespace Week2.Class.Movements
{
    public class TransfertMovement : Movement
    {
        public TransfertMovement(
            double amount, 
            string from, 
            string to) : base(amount)
        {
            this.FromBank = from;
            this.ToBank = to;
        }

        public string FromBank { get; set; }
        public string ToBank { get; set; }

        public override string ToString()
        {
            return $"{Amount} EUR Transfert from {FromBank} to {ToBank}.";
        }
    }
}

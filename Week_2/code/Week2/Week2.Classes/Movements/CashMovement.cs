using System;
using System.Collections.Generic;
using System.Text;

namespace Week2.Class.Movements
{
    public class CashMovement : Movement
    {
        public CashMovement(double amount, string madeBy) : base(amount)
        {
            this.MadeBy = madeBy;
        }

        public string MadeBy { get; set; }

        public override string ToString()
        {
            return $"Cash movement of {Amount} EUR, made by {MadeBy}.";
        }
    }
}

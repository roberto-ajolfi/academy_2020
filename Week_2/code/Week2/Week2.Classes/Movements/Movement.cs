using System;
using System.Collections.Generic;
using System.Text;

namespace Week2.Class.Movements
{
    public abstract class Movement
    {
        public Movement(double amount)
        {
            this.Amount = amount;
            this.Timestamp = DateTime.Now;
        }

        public double Amount { get; set; }
        public DateTime Timestamp { get; set; }

        public override string ToString()
        {
            return "Movement (abstract)";
        }
    }
}

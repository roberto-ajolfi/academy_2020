using System;
using System.Collections.Generic;
using System.Text;

namespace Week2.Class.Movements
{
    public class CreditCardMovement : Movement
    {
        public CreditCardMovement(
            double amount, 
            CreditCardType type, 
            string number) : base(amount)
        {
            this.Type = type;
            this.Number = number;
        }

        public enum CreditCardType
        {
            AMEX,
            VISA,
            MASTERCARD,
            OTHER
        }
        public CreditCardType Type { get; set; }
        public string Number { get; set; }

        public override string ToString()
        {
            return $"{Type} Credit Card No. {Number} expense of {Amount} EUR.";
        }
    }
}

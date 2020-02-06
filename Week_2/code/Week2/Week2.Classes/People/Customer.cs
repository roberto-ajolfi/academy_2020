using System;
using System.Collections.Generic;
using System.Text;

namespace Week2.Classes.People
{ 
    public class Customer : Person
    {
        public Customer(string firstname, string lastname, int age, bool married, string carta):base(firstname,lastname,age,married)
        {
            Creditcardnbr = carta;
        }

        public string Creditcardnbr { get; set; }

        public override string FirstName { 
            get => base.FirstName; 
            set => base.FirstName = value; 
        }

        public override string Hello()
        {
            string result = base.Hello();
            return $"{result} // {FirstName}, you're {Age} years old.";
        }

        public string CustomerHello()
        {
            string result = base.Hello();
            return $"{result}\n{FirstName}, you're {Age} years old.";
        }
    }
}

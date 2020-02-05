using System;
using System.Collections.Generic;
using System.Text;

namespace Week2.Classes.People
{
    public sealed class RetailCustomer : Customer
    {

    }

    public class Customer : Person
    {
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

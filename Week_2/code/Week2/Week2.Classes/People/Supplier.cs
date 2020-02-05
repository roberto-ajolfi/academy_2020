using System;
using System.Collections.Generic;
using System.Text;

namespace Week2.Classes.People
{
    public class Supplier : Person
    {
        public string Address { get; set; }

        public override string Hello()
        {
            return $"{FirstName} {LastName} {Age} {Address}";
        }
    }
}

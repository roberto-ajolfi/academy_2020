using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Week2.Classes.Shapes;

namespace Week2.Classes.People
{
    public class Supplier : Person, IColorFill
    {
        public Supplier(string firstname, string lastname, int age, bool married, string address) : base(firstname, lastname, age, married)
        {
            Address = address;  
        }
        public string Address { get; set; }
        public Color Color { get; set; }

        public void Fill()
        {
            Console.WriteLine("Person filled with {0}.", this.Color.ToString());
        }

        public override string Hello()
        {
            return $"{FirstName} {LastName} {Age} {Address}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Week1_Exercise
{
    class Product
    {
        #region State (Fields)

        private string _code;
        public string Code 
        {
            get
            {
                return _code.ToUpper();
            }
            set
            {
                if (value.StartsWith("A"))
                    throw new ArgumentException("A is not a valid code.");
                if (value.Length < 1)
                    throw new ArgumentException("Invalid code.");
                                                 
                _code = value;
            }
        }
        private double _price;
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Invalid Number.");
                _price = value;
            }
        }

        public string Description { get; set; }
        public DateTime Created { get; private set; }
        public DateTime Updated { get; set; } = DateTime.Today;

        #endregion

        #region Constructors
        public Product() : this("CODE", "", 1) {}

        public Product(string code, double price) : this(code, "", price) { }

        public Product(string code, string description, double price)
        {
            Code = code;
            Description = description;
            Price = price;
            Created = DateTime.Today;
        }

        #endregion

        #region Methods

        public double DiscountedPrice(double discount)
        {
            if (discount > 20.0)
            {
                discount = 20.0;
                Console.WriteLine("We cannot apply such a high discount. Max allowed is 20%");
            }
                
            return Price * (1 - (discount / 100.0));
        }

        public double ProductAge()
        {
            return (DateTime.Now - Created).TotalDays;
        }

        #endregion
    }
}

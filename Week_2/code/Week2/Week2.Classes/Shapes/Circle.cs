using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Week2.Classes.Shapes
{
    public class Circle : Shape, IColorFill
    {
        #region ctor

        public Circle(string name, double xCoor, double yCoor, double ray) : base(name)
        {
            //this.Name = name;
            this.X = xCoor;
            this.Y = yCoor;
            this.Ray = ray;
        }

        #endregion

        #region Properties

        public Color Color { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Ray { get; set; }

        public override double Area
        {
            get
            {
                return Math.PI * Math.Pow(this.Ray, 2);
            }
        }

        #endregion

        #region Methods

        public override string Draw()
        {
            return string.Format("Hello. I'm the {0} Circle, " +
                "located at ({1},{2}) with a ray = {3}.", 
                this.Name, this.X, this.Y, this.Ray);
        }

        public void Fill()
        {
            Console.WriteLine("Filled with {0}", 
                this.Color.ToString());
        }

        #endregion
    }
}

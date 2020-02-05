using System;
using System.Collections.Generic;
using System.Text;

namespace Week2.Classes.Shapes
{
    public class Triangle : Shape
    {
        #region ctor

        public Triangle(string name, double baseVal, double height)
        {
            this.Name = name;
            this.Base = baseVal;
            this.Height = height;
        }

        #endregion

        #region Properties

        public double Base { get; set; }
        public double Height { get; set; }

        public override double Area
        {
            get
            {
                return (this.Base * this.Height) / 2.0;
            }
        }

        #endregion

        #region Methods

        public override string Draw()
        {
            return string.Format("Hello. I'm the {0} Triangle, with " +
                "base = {1} and height = {2}).",
                this.Name, this.Base, this.Height);
        }

        #endregion
    }
}

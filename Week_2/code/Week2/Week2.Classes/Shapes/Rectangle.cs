using System;
using System.Collections.Generic;
using System.Text;

namespace Week2.Classes.Shapes
{
    public class Rectangle : Shape
    {
        #region ctor

        public Rectangle(string name, double width, double height)
        {
            this.Name = name;
            this.Width = width;
            this.Height = height;
        }

        #endregion

        #region Properties

        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area
        {
            get
            {
                return this.Width * this.Height;
            }
        }

        #endregion

        #region Methods

        public override string Draw()
        {
            return string.Format("Hello. I'm the {0} Rectangle, with " +
                "width = {1} and height = {2}).",
                this.Name, this.Width, this.Height);
        }

        #endregion
    }
}

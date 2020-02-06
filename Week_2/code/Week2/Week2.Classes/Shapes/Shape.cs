using System;
using System.Collections.Generic;
using System.Text;

namespace Week2.Classes.Shapes
{
    public abstract class Shape
    {
        #region ctor

        //public Shape() : this("NONAME") { }

        public Shape(string name)
        {
            this.Name = name;
        }

        #endregion

        #region Properties

        public string Name { get; set; }

        public virtual double Area { get; }

        #endregion

        #region Methods

        public abstract string Draw();
        //{
        //    return "I can't draw a Shape.";
        //}

        public virtual string Draw(string message)
        {
            return $"{message} ==> {this.Draw()}";
        }

        #endregion
    }
}

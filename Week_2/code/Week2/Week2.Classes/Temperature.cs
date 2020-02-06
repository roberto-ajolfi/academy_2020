using System;
using System.Collections.Generic;
using System.Text;

namespace Week2.Classes
{
    public class Temperature : IComparable
    {
        protected double temperatureInF;

        public double Fahrenheit 
        { 
            get
            {
                return this.temperatureInF;
            }
            set
            {
                this.temperatureInF = value;
            }
        }

        public double Celsius 
        {
            get
            {
                return (this.temperatureInF - 32) * (5.0/9);
            }
            set
            {
                this.temperatureInF = (value * 9.0 / 5) + 32;
            }
        }

        public int CompareTo(object obj)
        {
            Temperature t = obj as Temperature;

            if (t == null) return 1;

            return this.temperatureInF.CompareTo(t.temperatureInF);
        }
    }
}

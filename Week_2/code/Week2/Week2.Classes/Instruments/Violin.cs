using System;
using System.Collections.Generic;
using System.Text;

namespace Week2.Classes.Instruments
{
    public class Violin : Instrument
    {
        public Violin(string brand, int age) : base(brand)
        {
            this.Age = age;
        }

        public int Age { get; set; }

        public override void Play()
        {
            Console.WriteLine("Violin {0} is playing.", this.ID);
        }

        public override void Tune()
        {
            Console.WriteLine("Tuning violin {0} ...", this.ID);
        }

        public override string ToString()
        {
            return string.Format(
                "Violin {0} ({1}), age {2}.", 
                this.ID, 
                this.Brand, 
                this.Age);
        }
    }
}

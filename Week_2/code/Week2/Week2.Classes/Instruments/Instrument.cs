using System;
using System.Collections.Generic;
using System.Text;

namespace Week2.Classes.Instruments
{
    public abstract class Instrument
    {
        public Instrument(string brand)
        {
            this.Brand = brand;
            this.ID = Guid.NewGuid();
        }
        public string Brand { get; set; }
        public Guid ID { get; }

        public abstract void Play();

        public abstract void Tune();
    }
}

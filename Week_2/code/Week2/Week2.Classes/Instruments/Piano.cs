using System;
using System.Collections.Generic;
using System.Text;

namespace Week2.Classes.Instruments
{
    public class Piano : Instrument
    {
        public enum PianoType
        {
            Grand,
            Upright,
            Digital
        }

        public Piano(string brand, PianoType type) : base(brand)
        {
            this.Type = type;
        }

        public PianoType Type { get; set; }

        public override void Play()
        {
            Console.WriteLine(
                "{0} Piano {1} is playing.", 
                this.Type.ToString(),
                this.ID);
        }

        public override void Tune()
        {
            Console.WriteLine(
                "Tuning {0} piano {1} ...", 
                this.Type.ToString(),
                this.ID);
        }

        public override string ToString()
        {
            return string.Format(
                "Piano {0} ({1}), a {2} piano.",
                this.ID,
                this.Brand,
                this.Type.ToString());
        }
    }
}

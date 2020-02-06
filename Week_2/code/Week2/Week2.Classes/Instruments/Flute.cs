using System;
using System.Collections.Generic;
using System.Text;

namespace Week2.Classes.Instruments
{
    public class Flute : Instrument
    {
        public enum FluteType
        {
            EndBlow,
            SideBlow
        }

        public Flute(string brand, FluteType type) : base(brand)
        {
            this.Type = type;
        }

        public FluteType Type
        {
            get; set;
        }

        public override void Play()
        {
            Console.WriteLine(
                "{0} Flute {1} is playing.",
                this.Type.ToString(),
                this.ID);
        }

        public override void Tune()
        {
            Console.WriteLine(
                "Tuning {0} flute {1} ...",
                this.Type.ToString(),
                this.ID);
        }

        public override string ToString()
        {
            return string.Format(
                "Flute {0} ({1}), a {2} flute.",
                this.ID,
                this.Brand,
                this.Type.ToString());
        }
    }
}

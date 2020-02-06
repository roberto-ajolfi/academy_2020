using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Week2.Classes.Instruments;
using Week2.Classes.People;

namespace Week2.Classes.MusicEvents
{
    public class OperaConcertEvent : IMusicEvent
    {
        public OperaConcertEvent(
            Director director,
            Person composer) : this(director, composer, new ArrayList())
        {

        }

        public OperaConcertEvent(
            Director director, 
            Person composer, 
            ArrayList instruments)
        {
            this.Director = director;
            this.Composer = composer;
            this.Instruments = instruments;
        }

        public Director Director { get; set; }
        public Person Composer { get; set; }
        public ArrayList Instruments { get; set; }
    }
}

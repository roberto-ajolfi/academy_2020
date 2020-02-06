using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Week2.Classes.Instruments;
using Week2.Classes.People;

namespace Week2.Classes.MusicEvents
{
    public class ChamberConcertEvent : IMusicEvent
    {
        public ChamberConcertEvent(
            Person composer) : this(composer, new ArrayList())
        {

        }

        public ChamberConcertEvent(
            Person composer,
            ArrayList instruments)
        {
            this.Composer = composer;
            this.Instruments = instruments;
        }

        public Person Composer { get; set; }
        public ArrayList Instruments { get; set; }
    }
}

using System;
using System.Collections;
using Week2.Classes.Instruments;
using Week2.Classes.MusicEvents;
using Week2.Classes.People;

namespace Week2.Orchestra.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== GREAT OPERA CONCERT ===");

            Director director = new Director(
                "Roberto", "Ajolfi", 
                40, true, "Conservatorio di Milano");

            Person composer = new Person(
                "Ludwig", "Van Beethoven", 68, false);

            //OperaConcertEvent concert = new OperaConcertEvent(
            //    director,
            //    composer);

            ArrayList strumenti = new ArrayList();
            Piano piano = new Piano("Steinway & Sons", Piano.PianoType.Grand);
            Flute flute = new Flute("Miyazawa Flutes", Flute.FluteType.SideBlow);
            Violin firstViolin = new Violin("Stradivari", 280);
            Violin secondViolin = new Violin("Stentor", 30);

            strumenti.Add(piano);
            strumenti.Add(flute);
            strumenti.Add(firstViolin);
            strumenti.Add(secondViolin);

            OperaConcertEvent concert = new OperaConcertEvent(
                director,
                composer,
                strumenti);

            //concert.Instruments.Add(piano);
            //concert.Instruments.Add(flute);
            //concert.Instruments.Add(firstViolin);
            //concert.Instruments.Add(secondViolin);

            // PROVE GENERALI
            Console.WriteLine("--- PROVE GENERALI ---");
            foreach(Instrument instrument in concert.Instruments)
            {
                Console.WriteLine(instrument.ToString());
                instrument.Tune();
            }
            Console.WriteLine("--- FINE PROVE GENERALI ---");
            Console.WriteLine();

            // CONCERTONE !!
            Console.WriteLine("--- CONCERTONE ---");
            Console.WriteLine($"Opera di {concert.Composer.LastName}");
            Console.WriteLine($"--- Dirige: {concert.Director.LastName}");
            Console.WriteLine("------------------");
            foreach (Instrument instrument in concert.Instruments)
            {
                instrument.Play();
            }
            Console.WriteLine("--- FINE CONCERTONE ---");
        }
    }
}

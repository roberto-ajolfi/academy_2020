using System;
using System.Collections;
using Week2.Classes;
using Week2.Classes.Shapes;

namespace Week2.Shapes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList temperatures = new ArrayList();
            Random rnd = new Random();

            Console.WriteLine(" ---- UNSORTED ------");
            for (int idx = 0; idx < 10; idx++)
            {
                Temperature temp = new Temperature();
                temp.Fahrenheit = rnd.Next(0, 100);
                temperatures.Add(temp);
                Console.WriteLine("Temperature: {0}",
                    temp.Fahrenheit);
            }
            Console.WriteLine();

            temperatures.Sort();

            Console.WriteLine(" ---- SORTED ------");
            foreach (Temperature temp in temperatures)
                Console.WriteLine("Temperature: {0}", 
                    temp.Fahrenheit);


            //Console.WriteLine("===== SHAPES !!! ======");

            //Shape s = new Shape("Shape di Base");
            //Console.WriteLine(s.Draw("Messaggio Extra"));
            //Console.WriteLine($"Area: {s.Area}");
            //Console.WriteLine(s.Draw());
            //Console.WriteLine("======================");

            //Shape c = new Circle("CERCHIO UNO", 10, 5, 2);
            //Console.WriteLine(c.Draw("Un Cerchio!"));
            //Console.WriteLine($"Area: {c.Area}");
            //Console.WriteLine(c.Draw());
            //Console.WriteLine("======================");

            //Shape r = new Rectangle("PIPPO DUE", 10, 5);
            //Console.WriteLine(r.Draw("Uhhh! Un Rettangolo."));
            //Console.WriteLine($"Area: {r.Area}");
            //Console.WriteLine(r.Draw());
            //Console.WriteLine("======================");

            //Shape t = new Triangle("TRIANGOLO TRE", 5, 20);
            //Console.WriteLine(t.Draw("Ma che bel Triangolo!!"));
            //Console.WriteLine($"Area: {t.Area}");
            //Console.WriteLine(t.Draw());
            //Console.WriteLine("======================");

            //Shape[] forme = new Shape[]
            //{
            //    new Circle("CERCHIO UNO", 10, 5, 2),
            //    new Circle("CERCHIO DUE", 20, 2, 5),
            //    new Rectangle("PIPPO DUE", 10, 5),
            //    new Triangle("TRIANGOLO TRE", 5, 20)
            //};

            //for(int index = 0; index < forme.Length; index++)
            //{
            //    Console.WriteLine($"=== {forme[index].Name} ===");
            //    Console.WriteLine("{0}\nArea: {1}",
            //        forme[index].Draw(),
            //        forme[index].Area);

            //    if(forme[index] is Circle)
            //    {
            //        Circle c = (Circle)forme[index];
            //        Console.WriteLine($"({c.X}, {c.Y}) - Ray: {c.Ray}");
            //    }

            //    Rectangle r = forme[index] as Rectangle;
            //    Console.WriteLine("Width: {0}", 
            //        r != null ? r.Width.ToString() : "Not a Rectangle"    
            //    );

            //    Console.WriteLine();
            //}
        }
    }
}

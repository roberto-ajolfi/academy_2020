using System;
using Week2.Classes.Shapes;

namespace Week2.Shapes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== SHAPES !!! ======");

            Shape s = new Shape("Shape di Base");
            Console.WriteLine(s.Draw("Messaggio Extra"));
            Console.WriteLine($"Area: {s.Area}");
            Console.WriteLine(s.Draw());
            Console.WriteLine("======================");

            Circle c = new Circle("CERCHIO UNO", 10, 5, 2);
            Console.WriteLine(c.Draw("Un Cerchio!"));
            Console.WriteLine($"Area: {c.Area}");
            Console.WriteLine(c.Draw());
            Console.WriteLine("======================");

            Rectangle r = new Rectangle("RETTANGOLO DUE", 10, 5);
            Console.WriteLine(r.Draw("Uhhh! Un Rettangolo."));
            Console.WriteLine($"Area: {r.Area}");
            Console.WriteLine(r.Draw());
            Console.WriteLine("======================");

            Triangle t = new Triangle("TRIANGOLO TRE", 5, 20);
            Console.WriteLine(t.Draw("Ma che bel Triangolo!!"));
            Console.WriteLine($"Area: {t.Area}");
            Console.WriteLine(t.Draw());
            Console.WriteLine("======================");
        }
    }
}

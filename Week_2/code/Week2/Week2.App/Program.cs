using System;
using Week2.Classes;

namespace Week2.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====== Numeri Complessi =========");

            // MISC BUILDERS

            Complex cpx1 = new Complex(3, 4);
            Complex cpx1_equivalente = new Complex {
                Real = 3,
                Imaginary = 4
            };

            Complex cpx2 = new Complex("(5, 7)");
            Complex cpx3 = Complex.AdditionNeutral;
            Complex cpx4 = Complex.MultiplyNeutral;
            Complex cpx5 = Complex.CreateComplex(10, 4);

            Console.WriteLine("CPX1: {0}", cpx1.Print(Complex.PrintFormat.Readable));
            Console.WriteLine("CPX2: {0}", cpx2.Print(Complex.PrintFormat.Vector));
            Console.WriteLine("CPX3: {0}", cpx3.Print(Complex.PrintFormat.Readable));
            Console.WriteLine("CPX4: {0}", cpx4.Print(Complex.PrintFormat.Readable));
            Console.WriteLine("CPX5: {0}", cpx5.Print(Complex.PrintFormat.Readable));
            Console.WriteLine("!CPX5: {0}", (-cpx5).Print(Complex.PrintFormat.Readable));
            Console.WriteLine("|CPX5|: {0}", cpx5.Module);

            // MAIN LOOP
            bool next = true;
            while (next)
            {
                Console.WriteLine();
                Console.WriteLine("==========================================");
                Console.WriteLine();

                Console.Write("Parte Reale primo numero: ");
                string real1 = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Parte Immaginaria primo numero: ");
                string imm1 = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Parte Reale secondo numero: ");
                string real2 = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Parte Immaginaria secondo numero: ");
                string imm2 = Console.ReadLine();
                Console.WriteLine();

                Complex first = new Complex(double.Parse(real1), double.Parse(imm1));
                Complex second = new Complex(double.Parse(real2), double.Parse(imm2));

                Console.Write("Operazione: ");
                string operation = Console.ReadLine();

                Console.WriteLine("First: {0}", first.Print(Complex.PrintFormat.Readable));
                Console.WriteLine("Second: {0}", second.Print(Complex.PrintFormat.Readable));

                Complex result = Complex.AdditionNeutral;
                switch (operation)
                {
                    case "+":
                        result = first + second;
                        Console.WriteLine("Sum: {0}", result.Print(Complex.PrintFormat.Readable));
                        break;
                    case "-":
                        result = first - second;
                        Console.WriteLine("Subtract: {0}", result.Print(Complex.PrintFormat.Readable));
                        break;
                    case "*":
                        result = first * second;
                        Console.WriteLine("Multiple: {0}", result.Print(Complex.PrintFormat.Readable));
                        break;
                    case "/":
                        result = first / second;
                        Console.WriteLine("Divide: {0}", result.Print(Complex.PrintFormat.Readable));
                        break;
                    default:
                        Console.WriteLine("Unkwown Operation.");
                        break;
                }

                Console.Write("Ancora? (S/N)");
                string again = Console.ReadLine();
                Console.WriteLine();
                next = (again.ToUpper() == "S");
            }
        }
    }
}

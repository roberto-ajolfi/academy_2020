using System;
using Week2.Classes.People;

namespace Week2.Inheritance.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person p = new Person();
            p.FirstName = "Roberto";
            p.LastName = "Ajolfi";
            Console.WriteLine("Person => " + p.Hello());
            Console.WriteLine("Person.PrintMe => " + p.PrintMe("iuii", 78));

            Customer c = new Customer();
            c.FirstName = "Mauro";
            c.LastName = "Bussini";
            Console.WriteLine("Customer => " + c.Hello());
            //Console.WriteLine("Customer => " + c.CustomerHello());

            Supplier s = new Supplier();
            s.FirstName = "Sarah";
            s.LastName = "Consolino";
            s.Address = "Piazza Duca d'Aosta";
            Console.WriteLine("Supplier => " + s.Hello());

            Person p2 = new Person();
            p2.FirstName = "Rodolfo";
            p2.LastName = "Bosio";
            Person p1 = p + p2;
            Console.WriteLine("p + p2 => " + p1.Hello());
            p1++;
            Console.WriteLine("p1 => " + p1.Hello());
            Console.WriteLine("p1 > p2 => " + (p1 > p2));
        }
    }
}
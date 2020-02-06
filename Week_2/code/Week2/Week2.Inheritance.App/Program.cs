using System;
using Week2.Classes.People;

namespace Week2.Inheritance.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person[] people = new Person[]
            {
                new Customer("Giusy", "Resce", 22, false, "35366476"),
                new Supplier("Gerardo", "Sciocchino", 34, true, "non so"),
                new Customer("Enza", "Resce", 20, false, "156376484")
            };

            for(int index2 = 0; index2< people.Length; index2++)
            {
                Console.WriteLine("{0} {1}",
                    people[index2].FirstName,
                    people[index2].LastName);

                if(people[index2] is Customer)
                {
                    Customer c5 = (Customer)people[index2];
                    Console.WriteLine("Numero carta: {0}", c5.Creditcardnbr);
                }

                Supplier s1 = people[index2] as Supplier;
                Console.WriteLine("Indirizzo: {0}",
                    s1 != null ? s1.Address : "Non ha casa!!");
            }

            //Person p = new Person();
            //p.FirstName = "Roberto";
            //p.LastName = "Ajolfi";
            //Console.WriteLine("Person => " + p.Hello());
            //Console.WriteLine("Person.PrintMe => " + p.PrintMe("iuii", 78));

            //Customer c = new Customer();
            //c.FirstName = "Mauro";
            //c.LastName = "Bussini";
            //Console.WriteLine("Customer => " + c.Hello());
            ////Console.WriteLine("Customer => " + c.CustomerHello());

            //Supplier s = new Supplier();
            //s.FirstName = "Sarah";
            //s.LastName = "Consolino";
            //s.Address = "Piazza Duca d'Aosta";
            //Console.WriteLine("Supplier => " + s.Hello());

            //Person p2 = new Person();
            //p2.FirstName = "Rodolfo";
            //p2.LastName = "Bosio";
            //Person p1 = p + p2;
            //Console.WriteLine("p + p2 => " + p1.Hello());
            //p1++;
            //Console.WriteLine("p1 => " + p1.Hello());
            //Console.WriteLine("p1 > p2 => " + (p1 > p2));

            //Person p3 = p1 - p2;
            //Console.WriteLine("Padre Ignoto! " + p3.Hello());

        }

    }
}
using System;

namespace Week2.Ctor.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BASE ====");
            //Base b = new Base();
            //b.Name = "Pippo";
            Base b = new Base("Pippo");

            Console.WriteLine("====");
            Console.WriteLine("INHERITED ====");
            Inherited i = new Inherited();
            i.Name = "Paperinik";
            i.Age = 12;
        }
    }

    class Base
    {
        //public Base()
        //{
        //    Console.WriteLine("Base ctor");
        //}

        public Base(string name)
        {
            Console.WriteLine("Base with params ctor");
            this.Name = name;
        }

        public string Name { get; set; }
    }

    class Inherited : Base
    {
        public Inherited() : base("")
        {
            Console.WriteLine("Inherited ctor");
        }

        public Inherited(string name, int age) : base(name)
        {
            Console.WriteLine("Inherited ctor");
            this.Age = age;
        }

        public int Age { get; set; }
    }
}

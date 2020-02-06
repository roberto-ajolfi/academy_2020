using System;
using System.Collections.Generic;
using System.Text;

namespace Week2.Classes.People
{
    public class Person
    {
        public Person(string firstname, string lastname, int age, bool married)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            IsMarried = married;
        }

        public virtual string FirstName { get; set; }
        public string LastName { get; set; }
        protected int Age { get; set; }

        private bool IsMarried { get; set; }

        public virtual string Hello()
        {
            return $"Hello, {FirstName} {LastName} ({Age}), {IsMarried}";
        }

        public string PrintMe()
        {
            return "Printed!";
        }

        // ORRROOOOOORE!
        //public int PrintMe()
        //{
        //    return 13;
        //}

        public string PrintMe(string param)
        {
            return $"{param} Printed!";
        }

        public string PrintMe(int param)
        {
            return $"(int) {param} Printed!";
        }

        public string PrintMe(string param1, int param)
        {
            return $"(int) {param}, (string) {param1} Printed!";
        }

        public string PrintMe(int param, string param1)
        {
            return $"(int) {param}, (string) {param1} Printed!";
        }

        public static Person operator +(Person p1, Person p2)
        {
            //Person child = new Person();
            p1.FirstName = "Pippo";
            p1.LastName = $"{p1.LastName} {p2.LastName}";

            return p1;
        }

        public static Person operator -(Person p1, Person p2)
        {
            //Person child = new Person();
            p1.FirstName = "Pippo";
            p1.LastName = $"{p1.LastName} {p2.LastName}";

            return p1;
        }


        #region post-exercise

        public static Person operator++(Person p)
        {
            p.Age++;
            return p;
        }

        public static bool operator<(Person p1, Person p2)
        {
            return p1.Age < p2.Age;
        }

        public static bool operator >(Person p1, Person p2)
        {
            return !(p1 < p2);
        }

        #endregion
    }
}

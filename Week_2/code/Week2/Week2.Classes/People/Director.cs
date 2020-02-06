using System;
using System.Collections.Generic;
using System.Text;

namespace Week2.Classes.People
{
    public class Director : Person
    {
        public Director(
            string firstName,
            string lastName,
            int age,
            bool married,
            string musicSchool) : base(firstName, lastName, age, married)
        {
            this.MusicSchool = musicSchool;
        }

        public string MusicSchool { get; set; }
    }
}

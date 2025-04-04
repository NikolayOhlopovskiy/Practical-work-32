using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public int GetAge()
        {
            var today = DateTime.Today;
            int age = today.Year - BirthDate.Year;
            if (BirthDate > today.AddYears(-age)) age--;
            return age;
        }

        public abstract void PrintInfo();
    }
}

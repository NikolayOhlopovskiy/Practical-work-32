using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Applicant : Person
    {
      public string Faculty { get; set; }

          public Applicant(string firstName, string lastName, DateTime birthDate, string faculty)
            : base(firstName, lastName, birthDate)
          {
            Faculty = faculty;
          }

        public override void PrintInfo()
        {
            Console.WriteLine($"Абитуриент: {FirstName} {LastName}, Возраст: {GetAge()}, Факультет: {Faculty}");
        }
    }
}

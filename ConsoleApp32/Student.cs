using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Student : Person
    {
        public string Faculty { get; set; }
        public int Course { get; set; }

        public Student(string firstName, string lastName, DateTime birthDate, string faculty, int course)
            : base(firstName, lastName, birthDate)
        {
            Faculty = faculty;
            Course = course;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Студент: {FirstName} {LastName}, Возраст: {GetAge()}, Факультет: {Faculty}, Курс: {Course}");
        }
    }
}

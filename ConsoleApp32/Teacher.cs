using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Teacher : Person
    {
        public string Faculty { get; set; }
        public string Position { get; set; }
        public int Experience { get; set; }

        public Teacher(string firstName, string lastName, DateTime birthDate, string faculty, string position, int experience)
            : base(firstName, lastName, birthDate)
        {
            Faculty = faculty;
            Position = position;
            Experience = experience;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Преподаватель: {FirstName} {LastName}, Возраст: {GetAge()}, Факультет: {Faculty}, Должность: {Position}, Стаж: {Experience} лет");
        }
    }
}

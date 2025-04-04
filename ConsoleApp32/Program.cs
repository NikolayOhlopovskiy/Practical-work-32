using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>
            {
            new Applicant("Галина", "Иванова", new DateTime(2006, 7, 9), "Физико-математический"),
            new Student("Игорь", "Петров", new DateTime(2003, 3, 4), "Информатика", 3),
            new Teacher("Мария", "Сидорова", new DateTime(1980, 1, 26), "История", "Доцент", 15)
            };

            Console.WriteLine("Полная информация о всех персонах:");
            foreach (var person in people)
                person.PrintInfo();

            Console.WriteLine("\nВведите минимальный возраст:");
            int minAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите максимальный возраст:");
            int maxAge = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nПерсоны в возрасте от {minAge} до {maxAge}:");
            foreach (var person in people)
            {
                int age = person.GetAge();
                if (age >= minAge && age <= maxAge)
                    person.PrintInfo();
            }
            Console.ReadKey();
        }
    }

}

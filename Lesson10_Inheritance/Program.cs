using System;

namespace Lesson10_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("FIO", new DateTime(1990, 10, 6), "Odessa", "+380670000001");
            person.Email = "gates@microsoft.com";
            Console.WriteLine(person);

            Student student = new Student("FIO1", new DateTime(2002, 01, 9), "Odessa", "+380670000002", 2000, "151");
            student.Email = "bill@msn.com";
            Console.WriteLine(student);

            person.PassportDate = DateTime.Now;
            student.PassportDate = DateTime.Now;

        }
    }
}

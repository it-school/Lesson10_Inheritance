using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("FIO", new DateTime(1990, 10, 6), "Odessa", "+380670000001");
            Console.WriteLine(person);

            Student student = new Student("FIO1", new DateTime(1494, 01, 9), "Odessa", "+380670000002", 2000, "151");
            Console.WriteLine(student);

            person.PassportDate = DateTime.Now;
            student.PassportDate = DateTime.Now; 
        }
    }
}

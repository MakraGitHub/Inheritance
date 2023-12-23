using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[2];

            for(int i = 0; i < people.Length; i++)
            {
                Employee employee = new Employee();
                employee.Input();
                people[i] = employee;
            }
            Teacher teacher = new Teacher();
            teacher.Input();
            people[2] = teacher;

            foreach(Person person in people)
            {
                Console.WriteLine("Person Informations\n");
                person.Output();
                Console.WriteLine("----------------------");
            }
        }
    }
}

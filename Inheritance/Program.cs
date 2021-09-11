using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[2]
            {
                new Customer()
                {
                    FirstName = "İbrahim"
                },
                new Student()
                {
                    FirstName = "Yıldırım"
                }
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }
}

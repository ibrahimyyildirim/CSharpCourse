using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            // value type: int, bool, enum etc.

            int number1 = 10;
            int number2 = 20;
            number1 = number2;
            number2 = 30;

            Console.WriteLine(number1); // output:20

            // reference type: array, string, class, interfaca etc.

            string[] cities1 = new[]{"Ankara", "Aydın", "Amasya"};
            string[] cities2 = new[] { "Balıkesir", "Bursa", "Bilecik"};
            cities2 = cities1;
            cities1[0] = "İstanbul";
            Console.WriteLine(cities2[0]); // cities1'in referansini okudugu icin o referansin bellekteki degerini alir = İstanbul


            Console.ReadLine();

        }
    }
}

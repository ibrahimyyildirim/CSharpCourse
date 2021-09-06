using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 10;

            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else {
                Console.WriteLine("Number is not 10");
            }

            //Single Line If

            Console.WriteLine(number == 9 ? "Number is 9" : "Number is not 9") ;

            //Switch

            switch (number) 
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is not 10 or 20");
                    break;
            }


            Console.ReadLine();

        }
    }
}
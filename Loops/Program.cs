using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loop
            for (int i = 0; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }

            //while loop
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }

            //foreach loop
            string[] numbers = { "one", "two", "three", "four", "five", "six" };
            foreach (var number in numbers)
            {
                Console.WriteLine("number {0}", number);
            }


            PrimeNumber(23);

            Console.ReadLine();
        }

        static void PrimeNumber(int number)
        {

            bool isPrime = true;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (!isPrime)
            {
                Console.WriteLine("number {0} is not a prime number.", number);
            }
            else
            {
                Console.WriteLine("number {0} is a prime number.", number);
            }

        }
    }
}

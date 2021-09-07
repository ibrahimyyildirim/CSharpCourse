using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            var result = SumNumbers2(2);
            Console.WriteLine(result);

            int number1 = 10;
            int number2 = 20;
            Console.WriteLine(SumNumbers3(number1, ref number2));
            Console.WriteLine(number2);  //ref keywordu ile methodun icindeki degisikigi referans aliyor
            /* out keywordu ile ref keywordunun farki:
             * out baslangic deger atamasi gerektirmez ref gerektirir.
             * fakat out icin mutlaka tanimlandigi method icinde deger atamasi gerekir. */
            Console.WriteLine(SumNumbers4(1,2,3,4,5,6));

            Console.ReadLine();
        }

        //deger dondurmeyen method
        static void Add()
        {
            Console.WriteLine("added!");
        }

        //deger donduren method
        static int SumNumbers(int number1, int number2)
        {
            return number1 + number2;
        }

        //default parametreli method
        static int SumNumbers2(int number1, int number2 = 10)
        {
            return number1 + number2;
        }

        //ref keywordu
        static int SumNumbers3(int number1, ref int number2)
        {
            number2 = 30;
            return number1 + number2;
        }

        //method overloading 
        static int SumNumbers4(int number1, int number2, int number3)
        {
            return number1 + number2;
        }

        //params keywordu
        static int SumNumbers4(params int[] numbers)
        {
            return numbers.Sum();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Value Types */

            char character = 'A';
            Console.WriteLine("Character is: {0}", character);

            //degisken degildir, degisken tutmak icin kullanilir. ilk atanan degerin tipini alir
            var number7 = 10;
            Console.WriteLine("Number7 is {0}", number7);

            //1 bit
            bool condition = false;
            Console.WriteLine("Condition is {0}", condition);

            //8 bit
            byte number4 = 237;
            Console.WriteLine("Number4 is {0}", number4);

            //16 bit
            short number3 = 23725;
            Console.WriteLine("Number3 is {0}", number3);

            //32 bit
            int number1 = 1078668879;
            Console.WriteLine("Number1 is {0}", number1);

            //64 bit
            long number2 = 233434242677;
            Console.WriteLine("Number2 is {0}", number2);

            //64 bit
            double number5 = 14.5;
            Console.WriteLine("Number5 is {0}", number5);

            //128 bit
            decimal number6 = 14.5346534635M;
            Console.WriteLine("Number6 is {0}", number6);

            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Friday); //4 sonucu verecek (index)

            Console.ReadLine();
        }

        //Tekrar yazmanin onune gecmek icin kullanilir
        enum Days
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday

        }
    }
}

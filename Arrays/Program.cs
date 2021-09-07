using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[2];
            students[0] = "İbrahim";
            students[1] = "Yıldırım";

            string[] students2 = { "İbrahim", "Yıldırım" };

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            //multidimensional arrays
            string[,] regions = new String[2, 3]
            {
                {"İstanbul","Kocaeli","Edirne"},
                {"İzmir","Manisa","Aydın"}
            };

            // GetUpperBound arrayin satir ve sutununun en ust degerini alir
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++) 
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("***");
            }
            Console.ReadLine();
        }
    }
}

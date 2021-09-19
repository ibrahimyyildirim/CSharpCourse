using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Find();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                
            }
            Console.ReadLine();
        }

        private static void Find()
        {
            List<string> students = new List<string> {"Ahmet", "Mehmet", "Ayşe"};

            if (!students.Contains("Fatma"))
            {
                throw new RecordNotFoundException("Record not found");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }
    }
}

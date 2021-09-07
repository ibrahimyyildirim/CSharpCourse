using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();

            ProductManager productManager = new ProductManager();
            productManager.Delete();

            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Ahmet",
                LastName = "Ak",
                City = "İstanbul"
            };

            Console.WriteLine(customer.City); 

            Console.ReadLine();
        }
    }
}

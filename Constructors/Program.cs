using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(20);
            customerManager.Add();

            CustomerManager customerManager2 = new CustomerManager();
            customerManager2.Add();

            Product product = new Product()
            {
                Id = 1,
                Name = "İbrahim"
            };

            //Nesne ornekleri icin farkli bir contructor kullanimi
            Product product2 = new Product(2, "Yıldırım");


            //contructor injection
            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            //base class'in constructor'ına parametre gondermek
            PersonManager personManager = new PersonManager("Person");
            personManager.Add();


            Console.ReadLine();
        }
    }

    // Constructor: sinif new'lendiginde calisacak kod blogudur.

    class CustomerManager
    {
        private int _count = 10;

        public CustomerManager()
        {
            
        }

        //constructor overloading
        public CustomerManager(int count)
        {
            _count = count;
        }

        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added {0} items", _count);
        }

    }

    class Product
    {
        public Product()
        {
            
        }

        public int Id { get; set; }
        public string Name { get; set; }

        private int _Id;
        private string _Name;

        public Product(int Id, string Name)
        {
            _Id = Id;
            _Name = Name;
        }
    }
}

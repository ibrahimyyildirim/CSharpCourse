using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Book","Kitap");
            dictionary.Add("Table","Tablo");
            dictionary.Add("Computer","Bilgisayar");

            Console.WriteLine(dictionary["Table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("Glass"));
            Console.WriteLine(dictionary.ContainsKey("Table"));

            Console.ReadLine();
        }

        private static void List()
        {
            //Type-Safe Collections
            List<string> list = new List<string>();
            list.Add("Ankara");
            list.Add("İstanbul");


            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer {Id = 1, FirstName = "İbrahim"});
            customers.Add(new Customer {Id = 2, FirstName = "Yıldırım"});

            //farkli sekilde ekleme
            List<Customer> customers2 = new List<Customer>
            {
                new Customer {Id = 1, FirstName = "Ahmet"},
                new Customer {Id = 2, FirstName = "Ayşe"}
            };

            customers.AddRange(new Customer[2] //AddRange: Liste seklinde ekleme
            {
                new Customer {Id = 3, FirstName = "Ahmet"},
                new Customer {Id = 4, FirstName = "Ayşe"}
            });

            customers.Insert(0, new Customer {Id = 0, FirstName = "Hakan"}); //Insert: Belirtilen index'e ekler

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
        }

        private static void ArrayList()
        {
            //Type-Safe Collections olmadigi icin tum veri tipleri eklenebilir
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Ankara");
            arrayList.Add("İstanbul");
            arrayList.Add(1);
            arrayList.Add('A');

            foreach (var a in arrayList)
            {
                Console.WriteLine(a);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    /*Private: property tanımladığımızda default'u 'private'tır. Sadece tanımlandığı blok içinde geçerlidir.

    Protected: private'ın tüm özelliğini kapsar.
    Private'dan tek farkı tanımlanan method, property vs. intherite edildiği sınıflarda da kullanılabilir.

    Internal: class'ın default'u internal'dır.
    Bağlı bulunduğu projede referans ihtiyacı olmadan kullanılabilir.
    Üst classlar private ve protected olamaz ! Ancak iç içe classlar kullanılır.

    public: farklı bir projeden de kullanmak istediğimiz zaman kullanılır.*/
    class Customer
    {
        protected int Id;
    }

    class Student : Customer
    {
        public void Save()
        {
            Student student = new Student()
            {
                Id = 1
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            sqlServer.Delete();

            Oracle oracle = new Oracle();
            oracle.Add();
            oracle.Delete();

            Console.ReadLine();
        }
    }

    class Database
    {
        //override etmek icin virtual method seklinde yazilir
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql Code");
        }
    }

    class Oracle : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Oracle Code");
        }

    }
    
}

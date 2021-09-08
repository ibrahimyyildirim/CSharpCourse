using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Worker(),
                new Manager(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[]
            {
                new Manager(),
                new Worker()
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }
    }
}

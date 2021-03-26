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
            //List<IWorker> workers = new List<IWorker> { new Manager(),new Worker(),new Robot()};
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
            Console.ReadLine();
        }
    }
    interface IWorker
    {
        void Work(); 
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker, ISalary, IEat
    {
        public void Eat()
        {
            Console.WriteLine("Manager eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager getSalary");
        }

        public void Work()
        {
            Console.WriteLine("manager work");
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("worker eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("worker getSalary");
        }

        public void Work()
        {
            Console.WriteLine("worker work");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("robot work");
        }
    }
}

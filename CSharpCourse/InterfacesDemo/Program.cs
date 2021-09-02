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
                new Manager(),
                new Worker(),
               
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
    interface IGetSalary
    {
        void GetSalary();
    }
    class Manager : IWorker, IEat, IGetSalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager Eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager GetSalary");
        }

        public void Work()
        {
            Console.WriteLine("Manager Work");
        }
    }
    class Worker : IWorker, IEat, IGetSalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker Eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker GetSalary");
        }

        public void Work()
        {
            Console.WriteLine("Worker Work");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot Work");
        }
    }
}

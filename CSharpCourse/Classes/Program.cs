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
            customerManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirsName = "Ali";
            customer.LastName = "Can";
            customer.city = "İzmir";

            Customer customer2 = new Customer
            {
               Id=2, FirsName="Derin",LastName="Can",city="Batman"
            };
            Console.WriteLine(customer2.FirsName);
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added!");
        }
        public void Update()
        {
            Console.WriteLine("Customer Updated!");

        }
        
    }
}




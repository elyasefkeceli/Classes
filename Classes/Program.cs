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
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "elyase";
            customer.LastName = "keceli";
            customer.City = "ordu";

            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "faruk",
                LastName = "keceli",
                City="ankara"
            };
            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();

        }
    }
}

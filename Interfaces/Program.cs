using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "elyase", LastName = "keceli", CustomerNumber = "4323" };
            PersonManager personManager = new PersonManager();
            personManager.Add(customer1);
            personManager.Add(new Student {Id=1,FirstName="furkan",LastName="bayrak",StudentNumber="434" });
        }
    }
    interface IPerson
    {
       int Id { get; set; }
       string FirstName { get; set; }
       string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public string CustomerNumber { get; set; }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    class Student : IPerson
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string StudentNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}

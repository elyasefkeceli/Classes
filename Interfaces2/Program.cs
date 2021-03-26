using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface bir imzadır. new lenemez.
            IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();
            IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Update();
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());
            

            Console.ReadLine();
        }
    }
    interface IPersonManager
    {
        void Add();
        void Update();
    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müsteri eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Müsteri güncellendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi.");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajer güncellendi.");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}

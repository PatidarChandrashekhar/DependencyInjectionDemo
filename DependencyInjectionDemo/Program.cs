using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using System.Reflection;
using Models;
using Factory;

namespace DependencyInjectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            IEnumerable<ICustomer> customers = kernel.GetAll<ICustomer>();

            foreach (ICustomer customer in customers)
            {
                var admin = new Admin(customer);
                admin.GetCustomerDetails();
            }
            Console.ReadLine();
        }
    }

    public class DI : NinjectModule
    {
        public override void Load()
        {
            Bind<ICustomer>().To<RetailCustomer>();
            Bind<ICustomer>().To<WholeSaleCustomer>();
            Bind<ICustomer>().To<OtherCustomer>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface ICustomer
    {
        void GetDetails();
    }

    public class RetailCustomer : ICustomer
    {
        public void GetDetails()
        {
            Console.WriteLine("Retail Customer");
        }
    }

    public class WholeSaleCustomer : ICustomer
    {
        public void GetDetails()
        {
            Console.WriteLine("WholeSale Customer");
        }
    }

    public class OtherCustomer : ICustomer
    {
        public void GetDetails()
        {
            Console.WriteLine("Other Customer");
        }
    }
}

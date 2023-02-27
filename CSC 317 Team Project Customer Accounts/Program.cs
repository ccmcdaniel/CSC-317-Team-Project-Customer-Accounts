using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC_317_Team_Project_Customer_Accounts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            customer.Name = "Billy Bob";
            customer.Address = "123 Some Street";
            customer.City = "Hattiesburg";
            customer.State = "MS";
            customer.Zip = "39401";
            customer.Phone = "(555) 222 - 1111";
            customer.AccountBalance = 12000.00M;
            customer.LastPaymentDate = DateTime.Parse("9/23/2022");

            Console.WriteLine(customer);

        }
    }
}

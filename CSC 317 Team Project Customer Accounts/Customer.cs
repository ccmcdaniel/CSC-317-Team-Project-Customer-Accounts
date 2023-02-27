using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC_317_Team_Project_Customer_Accounts
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public decimal AccountBalance { get; set; }
        public DateTime LastPaymentDate { get; set; }

        public override string ToString()
        {
            //output the customer as a string.
            return base.ToString();
        }

    }

    class CustomerList
    { 
        private List<Customer> customerList;

        void FindCustomer()
        {
            // ...
        }

        void AddCustomer()
        {
            // ...
        }

        // William
        void RemoveCusomter(Customer c)
        {
            customerList.Remove(c);
        }

        // William
        void EditCustomerName(Customer c, string name)
        {
            c.Name = name;
        }
    }

}

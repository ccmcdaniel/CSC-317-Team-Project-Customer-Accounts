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

        
        public Customer(string name, string address, string city, string state, string zip, string phone, decimal accountBalance)
        {
            Name = name;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            AccountBalance = accountBalance;
            LastPaymentDate = DateTime.Now;

        }

        public override string ToString()
        {
            //output the customer as a string.
            return base.ToString();
        }

    }

    class CustomerList
    { 
        private List<Customer> customerList;

        void FindCustomer(string name)
        {
            for(int i = 0; i < customerList.Count; i++)
            {
                if (customerList[i].Name == name)
                { 
                    Console.WriteLine("Customer found! Printing data: ");
                    Console.WriteLine(customerList[i].ToString());
                }
                else
                {
                    Console.WriteLine("Customer not found!");
                }
            }
               
        }

        void AddCustomer(Customer dude)
        {
            customerList.Add(dude);
        }
    
        void RemoveCusomter()
        {

        }
        
        void EditCustomer()
        {

        }
    }

}

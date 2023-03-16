using System.Text;

namespace CSC_317_Team_Project_Customer_Accounts {
    internal class Customer {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public decimal AccountBalance { get; set; }
        public DateTime LastPaymentDate { get; set; }

        public override string ToString() {
            StringBuilder result = new StringBuilder();

            /* Desired Output
              
            Name: <name>
            --> Address
            -->City, State Zip
            -->Phone Number
            -->$Account Balance
            -->     Last payment made on xx/xx/xxxx
            */
            result.Append($"Name: {Name}\n");
            result.Append($"--> {City}, {State} {Zip}\n");
            result.Append($"--> {Phone}\n");
            result.Append($"--> Balance: &{AccountBalance}\n");
            result.Append($"--> Last payment made on {LastPaymentDate.ToShortDateString()}\n ");

            return result.ToString();
        }

    }

    class CustomerList
    { 
        private List<Customer> customerList;

        //Jerry
        void FindCustomer()
        {
            // ...
        }

        //Jerry
        void AddCustomer()
        {
            // ...
        }

        //William
        void RemoveCustomer(string name)
        {
            foreach(Customer c in customerList)
            {
                if (c.Name == name)
                    customerList.Remove(c);
            }
        }

        // William
        void EditCustomerName(Customer c, string name)
        {
            c.Name = name;
        }
    }

}

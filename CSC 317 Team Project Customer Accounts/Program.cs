namespace CSC_317_Team_Project_Customer_Accounts {
    class Program {
        public static void Main() {
            //example of Customer object
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

            //Example of ParkedCars object
            ParkedCars lot = new ParkedCars();
            lot.addCar("a","b","c", 11);
            lot.addCar("d","e","f", 12);
            lot.addCar("g","h","i", 13);
            lot.printCars();

            lot.removeCar(1);
            lot.printCars();
            
            lot.setCar(0, "j","k","l", 14);
            lot.printCars();
        }
    }
}
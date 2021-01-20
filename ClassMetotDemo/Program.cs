using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 0;
            customer1.FirstName = "Ahmet";
            customer1.LastName = "Aydın";
            customer1.CardNumber = "1111";

            Customer customer2 = new Customer();
            customer2.Id = 1;
            customer2.FirstName = "Fevzi";
            customer2.LastName = "Küçük";
            customer2.CardNumber = "2222";

            Customer customer3 = new Customer();
            customer3.Id = 2;
            customer3.FirstName = "Mustafa";
            customer3.LastName = "Korkmaz";
            customer3.CardNumber = "3333";

            Customer customer4 = new Customer();
            customer4.Id = 3;
            customer4.FirstName = "Mehmet";
            customer4.LastName = "Yalçın";
            customer4.CardNumber = "4444";

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);
            customerManager.AddCustomer(customer3);
            customerManager.AddCustomer(customer4);
            customerManager.ListCustomer(customers);
            customerManager.DeleteCustomer(customer3);
        }
    }
}


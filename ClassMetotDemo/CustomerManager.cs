using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " eklendi");
        }
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " silindi");
        }
        public void ListCustomer(Customer[] customers)
        {
            Console.WriteLine("***MÜŞTERİ LİSTESİ***");
            foreach (var customer in customers)
            {
                Console.WriteLine("Müşteri ID: " + customer.Id);
                Console.WriteLine("Müşteri Adı: " + customer.FirstName);
                Console.WriteLine("Müşteri soyadı: " + customer.LastName);
                Console.WriteLine("Müşteri Kart No: " + customer.CardNumber);
                Console.WriteLine("**********");
            }
            Console.WriteLine("***LİSTE SONU***");
        }
    }
}

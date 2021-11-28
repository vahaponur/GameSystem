using System;
using static System.Console;
using GameMarketSystem.Entity;
using GameMarketSystem.Concrete;

namespace GameMarketSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            WriteLine(customer1.FirstName);
            CustomerManager customerManager = new CustomerManager(new DatabaseValidator());
            customerManager.Register(customer1);

            ReadKey();

        }
    }
}

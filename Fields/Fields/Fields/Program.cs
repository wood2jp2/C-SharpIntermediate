using System;
using System.Collections.Generic;

namespace Fields
{

    class MainClass
    {
        public static void Main(string[] args)
        {

            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            Console.WriteLine(customer.Orders.Count);
            customer.Promote();
            var anotherCustomer = new Customer(2);

            Console.WriteLine(customer.Orders.Count);
        }
    }
}

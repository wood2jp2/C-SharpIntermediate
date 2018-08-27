using System;
using System.Collections.Generic;

namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();


        public Customer(int id)
        {
            Id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            Name = name;
        }

        public void Promote()
        {
            //...this will promote a customer to a 'Gold' customer

            // if you mistakenly re-initialize 'Orders' list here, and call Promote() on an instance of the Customer object, you reset the orders field to 0 (without a readonly modifier)
            // Orders = new List<Order>();
        }

    }
}

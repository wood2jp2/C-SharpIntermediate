using System;
using System.Collections.Generic;

namespace Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        // list of objects of type Order
        public List<Order> Orders;
    
        public Customer()
        {
            // initializing a list might be like setting an array = [] so that you can do 'array things' to it
            Orders = new List<Order>();
        }

        public Customer(int id) : this ()
        {
            this.Id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            this.Name = name;
        }
    }
}

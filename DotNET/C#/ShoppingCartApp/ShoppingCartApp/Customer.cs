using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCartApp
{
    class Customer
    {
        private int _id;
        private String _name;
        private List<Order> _orders = new List<Order>();

        public Customer(int id, String name)
        {
            _id = id;
            _name = name;
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public String Name
        {
            get
            {
                return _name;
            }
        }

        public List<Order> Order
        {
            get
            {
                return _orders;
            }

        }

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }
    }
}

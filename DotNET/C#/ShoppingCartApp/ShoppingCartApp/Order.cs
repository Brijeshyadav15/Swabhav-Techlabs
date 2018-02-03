using System;
using System.Collections.Generic;

namespace ShoppingCartApp
{
    class Order
    {
        private int _orderid;
        private DateTime _orderDate;
        private List<LineItem> _items;

        public Order(int orderid, DateTime orderDate)
        {
            _orderid = orderid;
            _orderDate = orderDate;
            _items = new List<LineItem>();
        }

        public void AddItem(LineItem lineitem)
        {
            _items.Add(lineitem);
        }

        public int OrderId
        {
            get
            {
                return _orderid;
            }
        }

        public DateTime OrderDate
        {
            get
            {
                return _orderDate;
            }
        }

        public List<LineItem> Items
        {
            get
            {
                return _items;
            }
        }

        public double CalculateCheckOutCost()
        {
            double checkoutcost = 0;
            foreach (LineItem item in _items)
            {
                checkoutcost += item.costofLineItem();
            }

            return checkoutcost;
        }

    }
}

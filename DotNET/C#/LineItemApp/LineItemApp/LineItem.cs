using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LineItemApp
{
    class LineItem
    {
        private int _id;
        private String _product;
        private int _quantity;
        private double _unitprice;

        public LineItem(int id, String product, int quantity, double unitprice)
        {
            _id = id;
            _product = product;
            _quantity = quantity;
            _unitprice = unitprice;
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public String Product
        {
            get
            {
                return _product;
            }
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }
        }

        public double UnitPrice
        {
            get
            {
                return _unitprice;
            }
        }

        public double CalculateTotal()
        {
            return Quantity * UnitPrice;
        }

        public override string ToString()
        {
            return Id + " " + Product + " " + Quantity + " " + UnitPrice;
        }
    }
}

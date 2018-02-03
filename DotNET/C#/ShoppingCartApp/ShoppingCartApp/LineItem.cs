using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCartApp
{
    class LineItem
    {
        private int _id;
        private int _qunatity;
        private Product _products;


        public LineItem(int id, int quantity, Product product)
        {
            _id = id;
            _qunatity = quantity;
            _products = product;
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public int Quantity
        {
            get
            {
                return _qunatity;
            }
        }

        public Product Product
        {
            get
            {
                return _products;
            }
        }

        public double costofLineItem()
        {
            return _products.calcDiscountCost() * Quantity;
        }

    }

}

using System;

namespace ShoppingCartApp
{
    class Product
    {
        private int _id;
        private String _name;
        private double _cost;
        private float _discount;

        public Product(int id, String name, double cost, float discount)
        {
            _id = id;
            _name = name;
            _cost = cost;
            _discount = discount;
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public double Cost
        {
            get
            {
                return _cost;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public float Discount
        {
            get
            {
                return _discount;
            }
        }

        public double calcDiscountCost()
        {
            return _cost > _discount ? _cost - (double)_discount : _cost;
        }
    }
}

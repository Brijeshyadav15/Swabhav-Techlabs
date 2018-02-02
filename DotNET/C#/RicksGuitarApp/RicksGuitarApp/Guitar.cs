using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicksGuitarApp
{
    class Guitar
    {
        private String _serialNumber;
        private double _price;
        private GuitarSpec _spec;

        public Guitar(String serialNumber, double price, GuitarSpec spec)
        {
            _serialNumber = serialNumber;
            _price = price;
            _spec = spec;
        }

        public string SerialNumber
        {
            get
            {
                return _serialNumber;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
        }

        public GuitarSpec Spec
        {
            get
            {
                return _spec;
            }

        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCPRefractorApp
{
    class FixedDeposit
    {
        private String _name;
        private double _amount;
        private int _period;
        private IFestivalRate _festivalrate;

        public FixedDeposit(String name, double amount, int period, IFestivalRate festivalrate)
        {
            _name = name;
            _amount = amount;
            _period = period;
            _festivalrate = festivalrate;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public double Amount
        {
            get
            {
                return _amount;
            }
        }

        public int Period
        {
            get
            {
                return _period;
            }
        }

        public double CalculateInterest()
        {
            return Amount * Period * _festivalrate.Rate() / 100;
        }

    }
}

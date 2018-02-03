using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCPViolationApp
{
    class FixedDeposit
    {
        private String _name;
        private double _amount;
        private int _period;
        private FestivalType _festival;

        public FixedDeposit(String name, double amount, int period, FestivalType festival)
        {
            _name = name;
            _amount = amount;
            _period = period;
            _festival = festival;
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

        public FestivalType Festival
        {
            get
            {
                return _festival;
            }
        }

        public double CalculateInterest()
        {
            float rate = 0;
            if (Festival == FestivalType.NORMAL)
            {
                rate = 7;
            }
            else if (Festival == FestivalType.DIWALI)
            {
                rate = 7.5f;
            }
            else if (Festival == FestivalType.NEWYEAR)
            {
                rate = 7.8f;
            }
            return Amount * Period * rate / 100;
        }

    }
}

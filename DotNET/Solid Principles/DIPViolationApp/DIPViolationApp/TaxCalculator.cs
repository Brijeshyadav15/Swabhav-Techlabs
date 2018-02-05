using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPViolationApp
{
    class TaxCalculator
    {
        private LogType _log;

        public TaxCalculator(LogType log)
        {
            _log = log;
        }

        public int CalculateTax(int amount, int rate)
        {
            int result = 0;
            try
            {
                result = amount / rate;
            }
            catch
            {
                if (_log == LogType.XML)
                    new XMLLogger().logError("Exception occured");
                else if (_log == LogType.TXT)
                    new TextLogger().logError("Exception occured");
            }
            return result;
        }
    }
}

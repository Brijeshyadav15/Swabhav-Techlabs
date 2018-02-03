using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCPRefractorApp
{
    class NewYearRate : IFestivalRate
    {
        public float Rate()
        {
            return 7.5f;
        }
    }
}

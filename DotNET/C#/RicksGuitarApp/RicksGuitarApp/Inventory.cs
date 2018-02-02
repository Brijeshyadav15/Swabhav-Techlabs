using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicksGuitarApp
{
    class Inventory
    {
        private static List<Guitar> guitars = new List<Guitar>();
        private IEnumerator<Guitar> iterator = guitars.GetEnumerator();

        public void AddGuitar(String serialNumber, double price, GuitarSpec spec)
        {
            guitars.Add(new Guitar(serialNumber, price, spec));
        }

        public Guitar GetGuitar(String serialNumber)
        {
            using (iterator)
            {
                while (iterator.MoveNext())
                {
                    if (iterator.Current.SerialNumber.Equals(serialNumber))
                        return iterator.Current;
                }
            }
            return null;
        }

        public List<Guitar> search(GuitarSpec searchSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();

            foreach (Guitar guitar in guitars)
            {
                if (guitar.Spec.matches(searchSpec))
                    matchingGuitars.Add(iterator.Current);
            }
            return matchingGuitars;
        }
    }
}

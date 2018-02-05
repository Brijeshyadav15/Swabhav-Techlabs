using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISPViolationApp
{
    interface IWorkable
    {
        void StartsWork();

        void EndsWork();

        void StartsEat();

        void EndsEat();
    }
}

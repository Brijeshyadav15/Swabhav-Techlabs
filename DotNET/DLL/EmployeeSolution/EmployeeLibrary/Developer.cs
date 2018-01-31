using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeLibrary
{
    public class Developer : Employee
    {
        public override int CalculateSalary()
        {
            return Basic + Pa;
        }
    }
}

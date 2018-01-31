using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeLibrary
{
    public class Manager : Employee
    {
        public override int CalculateSalary()
        {
            return Basic + Pa + HRA;
        }
    }
}

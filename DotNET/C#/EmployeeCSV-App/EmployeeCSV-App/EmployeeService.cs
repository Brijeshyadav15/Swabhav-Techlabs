using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EmployeeCSV_App
{
    class EmployeeService
    {
        HashSet<Employee> employeeset = new HashSet<Employee>();

        public EmployeeService()
        {
            init();
        }

        public void init()
        {

            try
            {
                StreamReader reader = new StreamReader("dataFile.txt");
                String line;
                using (reader)
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        String[] emp1 = line.Split(',');

                        emp1[1] = emp1[1].Replace("'", "");
                        emp1[2] = emp1[2].Replace("'", "");
                        emp1[3] = emp1[3].Replace("'", "");
                        emp1[4] = emp1[4].Replace("'", "");
                        Employee e = new Employee(Convert.ToInt32(emp1[0]), emp1[1], emp1[2], emp1[3],
                                Convert.ToDateTime(emp1[4]), Convert.ToInt32(emp1[5]), emp1[6], emp1[7]);
                        employeeset.Add(e);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured");
            }
        }


        public HashSet<Employee> GetEmployees()
        {
            return employeeset;
        }
    }
}

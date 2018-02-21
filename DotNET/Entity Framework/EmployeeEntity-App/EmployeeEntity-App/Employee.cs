using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeEntity_App
{
    class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public int Manager { get; set; }
        public DateTime HireDate { get; set; }
        public int Salary { get; set; }
        public int Commision { get; set; }
        public int DeptId { get; set; }
    }
}

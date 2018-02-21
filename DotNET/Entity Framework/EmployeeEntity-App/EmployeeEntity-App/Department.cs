using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeEntity_App
{
    class Department
    {
        public Department()
        {
        }

        public Department(int id, string name, string loc)
        {
            Id = id;
            Name = name;
            Location = loc;
        }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}

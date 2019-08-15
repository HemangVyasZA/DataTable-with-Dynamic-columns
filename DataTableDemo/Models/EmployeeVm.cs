using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTableDemo.Models
{
    public class EmployeeVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfJoin { get; set; }
        public decimal Salary { get; set; }
        public bool IsHod { get; set; }
        public string EmployeeType { get; set; }
        public string Department { get; set; }
    }
}

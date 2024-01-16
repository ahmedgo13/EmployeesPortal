using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeDeps.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        ICollection<Employee> Employees { get; set; }
    }
}
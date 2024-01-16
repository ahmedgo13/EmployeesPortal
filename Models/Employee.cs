using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeDeps.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }

        ICollection<Department> Departments { get; set; }
    }
}
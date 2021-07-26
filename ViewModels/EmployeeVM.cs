using SingleViewCURD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SingleViewCURD.ViewModels
{
    public class EmployeeVM
    {
        public Employee EmployeeSingle { get; set; }
        public List<Employee> EmployeeList { get; set; }
    }
}
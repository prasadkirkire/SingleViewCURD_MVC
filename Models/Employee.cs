using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SingleViewCURD.Models
{
    [Table("EmployeeTbl")]
    public class Employee
    {
        [Key]
        public Int64 EmployeeID { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmailID { get; set; }
    }
}
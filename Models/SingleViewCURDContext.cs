using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SingleViewCURD.Models
{
    public class SingleViewCURDContext:DbContext
    {
        public DbSet<Employee> EmployeeTbls { get; set; }
    }
}
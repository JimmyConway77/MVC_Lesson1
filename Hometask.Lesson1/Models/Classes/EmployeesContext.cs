using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Hometask.Lesson1.Models.Classes
{
    public class EmployeesContext : DbContext
    {
        public DbSet<Employees> EmployeesTable { get; set; }
     //   public DbSet<EmployeeDetails> EmployeeDetailsTable { get; set; }


    }
}
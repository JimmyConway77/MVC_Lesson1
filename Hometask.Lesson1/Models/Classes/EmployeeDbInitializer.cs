using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Hometask.Lesson1.Models.Classes
{
    public class EmployeeDbInitializer : DropCreateDatabaseAlways<EmployeesContext>
    {
        protected override void Seed(EmployeesContext db)
        {
            db.EmployeesTable.Add(new Employees { ID = 1, Name = "Ivan", Surname = "Ivanoff", Position = "Director",
                Age = 39, Dob = new DateTime(1977, 04, 02), StartWorkDate = new DateTime(2011, 05, 01) });
            db.EmployeesTable.Add(new Employees { ID = 2, Name = "Petr", Surname = "Petroff", Position = "Accountant",
                Age = 51, Dob = new DateTime(1965, 01, 12),StartWorkDate = new DateTime(2011, 05, 01) });
            db.EmployeesTable.Add(new Employees { ID = 3, Name = "Sidor", Surname = "Sidoroff", Position = "Manager",
                Age = 35, Dob = new DateTime(1981, 11, 11), StartWorkDate = new DateTime(2011, 05, 01) });
            db.EmployeesTable.Add(new Employees { ID = 4, Name = "Maks", Surname = "Maksimoff", Position = "Manager",
                Age = 34, Dob = new DateTime(1982, 07, 07), StartWorkDate = new DateTime(2011, 05, 01) });

        /*    db.EmployeeDetailsTable.Add(new EmployeeDetails { Emp_ID = 1, Age = 39, Dob = new DateTime(1977, 04, 02), StartWorkDate = new DateTime(2011, 05, 01) });
            db.EmployeeDetailsTable.Add(new EmployeeDetails { Emp_ID = 2, Age = 51, Dob = new DateTime(1965, 01, 12), StartWorkDate = new DateTime(2011, 05, 01) });
            db.EmployeeDetailsTable.Add(new EmployeeDetails { Emp_ID = 3, Age = 35, Dob = new DateTime(1981, 11, 11), StartWorkDate = new DateTime(2011, 05, 01) });
            db.EmployeeDetailsTable.Add(new EmployeeDetails { Emp_ID = 4, Age = 34, Dob = new DateTime(1982, 07, 07), StartWorkDate = new DateTime(2011, 05, 01) }); */

            base.Seed(db);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hometask.Lesson1.Models.Classes
{
    public class EmployeeDetails
    {
        [Key]
        public int Emp_ID { get; set; }
        public DateTime Dob { get; set; }
        public DateTime StartWorkDate { get; set; }
        public int Age { get; set; }
        //public DateTime EndWorkDate;
        //public int EmploymentTerm;
        //public string Status;

        /*   public EmployeeDetails (int _Id, DateTime _Dob, DateTime _StartWorkDate, DateTime _EndWorkDate)
           {
               this.ID = _Id;
               this.Dob = _Dob;
               this.StartWorkDate = _StartWorkDate;
               this.EndWorkDate = _EndWorkDate;

               DateTime today = DateTime.Now;
               int age = today.Year - Dob.Year;
               if (today.Month < Dob.Month ||
                   (today.Month == Dob.Month && today.Date < Dob.Date)) age--;

               this.Age = age;

               int employmentTerm = today.Year - StartWorkDate.Year;
               if (today.Month < StartWorkDate.Month ||
                   (today.Month == StartWorkDate.Month && today.Date < StartWorkDate.Date)) employmentTerm--;

               this.EmploymentTerm = employmentTerm;

               if (this.EndWorkDate != null) this.Status = "Retired";
               else this.Status = "Active";

           } */


    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hometask.Lesson1.Models.Classes
{
    public class Employees
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public DateTime Dob { get; set; }
        public DateTime StartWorkDate { get; set; }
        public int Age { get; set; }
    }
}
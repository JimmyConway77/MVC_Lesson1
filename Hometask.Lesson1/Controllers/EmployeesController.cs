using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hometask.Lesson1.Models.Classes;

namespace Hometask.Lesson1.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        EmployeesContext db = new EmployeesContext();

        public ActionResult Index()
        {
            IEnumerable<Employees> employees = db.EmployeesTable;
            ViewBag.Employees = employees;
            return View();
        }

        public ActionResult ViewEmployee (int id)
        {
            ViewBag.ID = id;
            return View();
        }
    }
}
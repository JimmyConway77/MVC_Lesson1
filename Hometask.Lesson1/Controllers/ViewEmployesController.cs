using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hometask.Lesson1.Controllers
{
    public class ViewEmployesController : Controller
    {
        // GET: ViewEmployees
        public ActionResult ViewEmployees(int id)
        {
            ViewBag.ID = id;
            return View("Index");
        }
    }
}
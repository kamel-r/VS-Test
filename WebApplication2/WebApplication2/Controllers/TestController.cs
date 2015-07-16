using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public string GetString()
        {
            return "Helloooooooooo";
        }
        [NonAction]
        public string GetNothingBack()
        {

            return "hekk";
        }

        public ActionResult MyView()
        {
           

            Employee emp = new Employee();

            emp.FirstName = "Johny";

          //  ViewData["Employee1"] = emp;

           // ViewBag.Employee = emp;

           return View("MyView",emp);
            

        }
    }
}
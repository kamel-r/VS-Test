using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.ViewModels;
namespace WebApplication3.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyView()
        {
            EmployeeViewModel m = new EmployeeViewModel();

            m.EmployeeName = "Kamel";


            return View("MyView", m);

            


        }
    }
}
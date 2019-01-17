using mvc5.toturial.ashish.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc5.toturial.ashish.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {

            List<Employee> list = new List<Employee>();
            list.Add(new Employee {EmployeeId = 1, Name = "Joao", Departament = "TI" } );
            list.Add(new Employee {EmployeeId = 2, Name = "Maria", Departament = "RH" });
            list.Add(new Employee {EmployeeId = 3, Name = "Tonho", Departament = "ADM" });

            ViewData["empList"] = list;

            ViewBag.name = "Teste ViewBag";

            ViewData["dataname"] = "teste viewdata";

            TempData["tempname"] = "teste tempdata";

            TempData.Keep();

            return View();
        }

        public ActionResult SecondPage()
        {
            
            return View();
        }
    }
}
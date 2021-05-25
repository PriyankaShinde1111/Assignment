using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCDemoApp6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemoApp6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("Home/Greet/{name?}")]
        public IActionResult Greet(string name)
        {
            //return Content("Welcome to MVC");
            //return View("Greet1"); ///if our view has different name then use parametrized view() and pass name of view
            ViewBag.wish = "Hello " +name;
            return View();
        }

        public IActionResult GetData(int id)
        {
            ViewBag.message = "Id = " + id;
            return View();
        }


        //[HttpPost("Home/AddNumbers/{first:int:range(1,100)}/{second:int?}")]
        [Route("[controller]/[action]/{first:int:range(1,100)}/{second:int?}")]
        //[Route("Home/AddNumbers/{first:int:range(1,100)}/{second:int?}")]
        public  IActionResult AddNumbers(int first,int second)
        {
            int result = first + second;
            ViewBag.add = $"{first}+{second}={result}";
            return View();
        }

        public IActionResult ModelDemo()
        {
            Employee employee = new Employee { EmpId = 1, EmpName = "Priya", Salary = 10000 };
            //ViewBag.emp = employee;
            ViewData["emp"] = employee;
            return View();
        }

        public IActionResult EmployeeForm()
        {
            return View(new Employee());
        }

        public IActionResult DisplayEmployeeData(Employee employee)
        {
            if(ModelState.IsValid)
            {
                return View(employee);
            }

            return View("Employee",employee);
        }
        
    }
}

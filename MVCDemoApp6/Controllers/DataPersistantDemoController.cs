using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MVCDemoApp6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks; 

namespace MVCDemoApp6.Controllers
{
    public class DataPersistantDemoController : Controller
    {
        public IConfiguration Configuration { get; }

        public DataPersistantDemoController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }
        public IActionResult Index()
        {
            ViewBag.data = Configuration["customkey"];
            return View();
        }

        public IActionResult SessionDemo()
        {
            //create session values
            //HttpContext.Session.SetString(key, value);
            HttpContext.Session.SetString("message", "Session test");
            HttpContext.Session.SetInt32("count", 5);

            HttpContext.Session.SetString("dateobj", JsonSerializer.Serialize(DateTime.Now));

            Employee employee = new Employee() { EmpId = 101, EmpName = "Priyanka", Salary = 30000 };
            string empserializedata = JsonSerializer.Serialize(employee);
            HttpContext.Session.SetString("empobj", empserializedata);

            return RedirectToAction("GetSessionvalues");
        }

        public IActionResult GetSessionValues()
        {
            //read session value
            ViewBag.message = HttpContext.Session.GetString("message");
            ViewBag.count = HttpContext.Session.GetInt32("count");

            var dateobj = HttpContext.Session.GetString("dateobj");
            ViewBag.date = JsonSerializer.Deserialize<DateTime>(dateobj);

            string emp = HttpContext.Session.GetString("empobj");
            Employee empobj = JsonSerializer.Deserialize<Employee>(emp);
            ViewBag.emp = empobj;

            return View();
        }

        public IActionResult WriteCookies(string setting,string settingValue,bool isPersistant)
        {
            if(isPersistant)
            {
                CookieOptions options = new CookieOptions();
                options.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Append(setting, settingValue, options);
            }

            else
            {
                Response.Cookies.Append(setting, settingValue);
            }

            ViewBag.Message = "Cookie written successfully";
            return View("Index");
        }

        public IActionResult ReadCookies()
        {
            ViewBag.FontName = Request.Cookies["fontName"];
            ViewBag.FontSize = Request.Cookies["fontSize"];
            ViewBag.Color = Request.Cookies["color"];

            if(string.IsNullOrEmpty(ViewBag.FontName))
            {
                ViewBag.FontName = "Arial";
            }
            if (string.IsNullOrEmpty(ViewBag.FontSize))
            {
                ViewBag.FontSize = "22px";
            }
            if (string.IsNullOrEmpty(ViewBag.Color))
            {
                ViewBag.Color = "Black";
            }
            return View();
        }
    }
}

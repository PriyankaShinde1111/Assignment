using Microsoft.AspNetCore.Mvc;
using MVCDemoApp6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemoApp6.Controllers
{
    public class AssignmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegistrationForm()
        {
            return View(new RegisteredEntries());
        }

        public IActionResult RegisterPerson(RegisteredEntries newEntry, string confirmation)
        {
            if (ModelState.IsValid)
            {
      
                return View(newEntry);
            }
            
            if (confirmation.Equals("true"))
            {
                ViewBag.message = "Thanks for showing your interest for attending seminar";
                
            }
            else
            {
                ViewBag.message = "Sorry, but you are not registered for attending the seminar";
            }
            
            return View("RegisterPerson", newEntry);

        }
    }
}

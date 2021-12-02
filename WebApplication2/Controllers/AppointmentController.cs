using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    public class AppointmentController : Controller // inherits from controller 
    {
        public IActionResult Index() // index method that will return an action result. 
        {
            return View();
           
        }
    }
}
 
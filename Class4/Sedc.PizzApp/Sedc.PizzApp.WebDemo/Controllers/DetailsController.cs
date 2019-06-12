using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sedc.PizzApp.WebDemo.Controllers
{
    public class DetailsController : Controller
    {
        public IActionResult Details()
        {
         
        
            return View();
        }

        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MusicStore.Controllers
{
    public class MusicStoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
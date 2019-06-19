using Microsoft.AspNetCore.Mvc;
using Sedc.PizzApp.WebDemo.Models;
using System.Collections.Generic;
using System.Linq;

namespace Sedc.PizzApp.WebDemo.Controllers
{
    public class DrinkController : Controller
    {
        private static List<Drink> drinks = new List<Drink>
        {
            new Drink {Id = 1,Name = "CocaCola", Price = 100},
            new Drink {Id = 2,Name = "Watter", Price = 200},
            new Drink {Id = 3,Name = "Whiskey", Price = 300}
        };
    }
}

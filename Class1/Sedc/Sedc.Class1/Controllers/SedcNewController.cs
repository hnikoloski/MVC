using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sedc.Class1.Controllers
{
    public class SedcNewController : Controller
    {
        private string[] groups = new string [] {"g1","g2","g3","g4","g7","g6","g7","g8"};

        public string[] GetGroups(int skip, int take)
        {
            return groups.Skip(skip).Take(take).ToArray();
        }
        public string Index()
        {
            int number = 8;
            return "g1,g2,g3,g4,g5,g6,g7";
        }
        public int  GetNumberOfGroups()
        {
            return 8;
        }
    }
}
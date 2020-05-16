using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Eventique.Controllers
{
    public class WeddingHallsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
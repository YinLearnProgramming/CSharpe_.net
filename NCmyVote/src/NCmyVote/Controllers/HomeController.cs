using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NCmyVote.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "The object of this application";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult VotingLocation()
        {
            ViewData["Message"] = "Your contact page.";

            return View();

        }

        public IActionResult Candidates()
        {
            return View();
        }

        public IActionResult Information()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}

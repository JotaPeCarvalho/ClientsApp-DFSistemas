using ClientApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ClientApp.Controllers
{
    public class HomeController : Controller
    {

        //Home View
        public IActionResult Index()
        {
            return View();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Final.Models;
using Microsoft.AspNetCore.Authorization;
using Final.Services;

namespace Final.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private productoServices _productoServices;

        public HomeController(productoServices productoServices)
        {
            _productoServices = productoServices;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

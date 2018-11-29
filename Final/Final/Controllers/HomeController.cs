﻿using System;
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
        private FacturaServices _facturaServices;

        public HomeController(productoServices productoServices,
                              FacturaServices facturaServices)
        {
            _productoServices = productoServices;
            _facturaServices = facturaServices;
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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using stocks.Models;

namespace stocks.Controllers
{
    public class StocksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
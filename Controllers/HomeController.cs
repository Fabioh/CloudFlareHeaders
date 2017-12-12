using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestCF.Models;

namespace TestCF.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["CF-Connecting-IP"] = Request.Headers["CF-Connecting-IP"];
            ViewData["RemoteIpAddress"] = Request.HttpContext.Connection.RemoteIpAddress;
			ViewData["CF-IPCountry"] = Request.Headers["CF-IPCountry"];
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

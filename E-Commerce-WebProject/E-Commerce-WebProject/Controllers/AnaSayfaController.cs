using Dropbox.Api.TeamLog;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_WebProject.Controllers
{
    [Authorize(Roles = "B")]
    public class AnaSayfaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryDetails(int id)
        {
            ViewBag.x = id;

            return View();
        }
    }
}

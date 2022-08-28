using DataAccessLayer;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace E_Commerce_WebProject.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(Admin p)
        {
            var dataValue = c.Admins.FirstOrDefault(x =>
            x.UserName == p.UserName &&
            x.Password == p.Password);

            if (dataValue != null)
            {
                var adminRole = dataValue.AdminRole;
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Role, adminRole)
                };
                var userIdentity = new ClaimsIdentity(claims, "Login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync(principal);
                if (adminRole == "A")
                {
                    return RedirectToAction("Index", "Category");
                }
                else if (adminRole == "B")
                {
                    return RedirectToAction("Index", "AnaSayfa");
                }
            }

            return View("Index", "Login");
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }
    }
}

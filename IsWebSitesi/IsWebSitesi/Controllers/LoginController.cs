using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using IsWebSitesi.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IsWebSitesi.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        Context c = new Context();

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSignInViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.username, p.password, false, true);
                if (result.Succeeded)
                {
                    // Kullanıcı "Admin" rolünde mi kontrol et
                    if (User.IsInRole("Admin"))
                    {
                        // Admin alanına yönlendir
                        return RedirectToAction("Index", "Widget", new { area = "Admin" });
                    }
                    // Kullanıcı "Member" rolünde mi kontrol et
                    else if (User.IsInRole("Member"))
                    {
                        // Member alanına yönlendir
                        return RedirectToAction("Index", "Profile", new { area = "Member" });
                    }
                    // Kullanıcı "Company" rolünde mi kontrol et
                    else if (User.IsInRole("Company"))
                    {
                        var username = User.Identity.Name;
                        // Kullanıcının kimliğini (Id) bul
                        var userId = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
                        // Kullanıcının şirketini bul
                        var company = c.Companies.FirstOrDefault(x => x.AppUserId == userId);

                        if (company != null)
                        {
                            return RedirectToAction("Index", "DashBoard");
                        }
                        else
                        {
                            return RedirectToAction("RegisterCompany", "RegisterUser");
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Geçersiz giriş denemesi.");
                    return View(p);
                }

            }
            return View(p);
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }
    }
}

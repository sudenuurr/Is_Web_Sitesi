using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using IsWebSitesi.Areas.Member.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsWebSitesi.Areas.Member.Controllers
{
    [Area("Member")]
    public class ProfileController : Controller
    {
        Context c = new Context();
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserUpdateModel model = new UserUpdateModel();
            model.namesurname = values.NameSurname;
            model.imageurl = values.ImageUrl.ToString();
            model.username = values.UserName;
            model.mail = values.Email;
            model.password = values.PasswordHash;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Index (UserUpdateModel model)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            values.NameSurname = model.namesurname;
            values.UserName = model.username;
            values.Email = model.mail;
            if (!string.IsNullOrEmpty(model.password))
            {
                values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, model.password);
            }
            var result = await _userManager.UpdateAsync(values);
            return RedirectToAction("Index", "Profile");
        }

    }
}

using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using IsWebSitesi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IsWebSitesi.Controllers
{
    [AllowAnonymous]
    public class RegisterUserController : Controller
    {
        CompanyManager _companyManager = new CompanyManager(new EfCompanyRepository());
        CityManager _cityManager = new CityManager(new EfCityRepository());
        Context c = new Context();

        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        

        public RegisterUserController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult Index()
        {

            List<SelectListItem> roller = (from x in _roleManager.Roles.Where(r => r.Name != "Admin")
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.Id.ToString()
                                           }).ToList();

            ViewBag.roller = roller;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSignUpViewModel p)
        {
            List<SelectListItem> roller = (from x in _roleManager.Roles.Where(r => r.Name != "Admin")
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.Id.ToString()
                                           }).ToList();

            ViewBag.roller = roller;
            if (!p.IsAcceptTheContract)
            {
                ModelState.AddModelError("IsAcceptTheContract",
                    "Sayfamıza kayıt olabilmek için gizlilik sözleşmesini kabul etmeniz gerekmektedir.");
                return View(p);
            }

            if (ModelState.IsValid)
            {
                if (p.ConfirmPassword == p.Password)
                {
                    var rolename = c.Roles.Find(p.RolID).ToString();
                    AppUser user = new AppUser();

                    if (p.ImageUrl != null)
                    {
                        var extension = Path.GetExtension(p.ImageUrl.FileName);
                        var newImageName = Guid.NewGuid() + extension;
                        var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CompanyImage/", newImageName);
                        using (var stream = new FileStream(location, FileMode.Create))
                        {
                            await p.ImageUrl.CopyToAsync(stream);
                        }
                        user.ImageUrl = newImageName;
                    }

                    user.Email = p.Mail;
                    user.UserName = p.UserName;
                    user.NameSurname = p.NameSurname;
                    

                    var result = await _userManager.CreateAsync(user, p.Password);
                    if (result.Succeeded)
                    {
                        var roleName = rolename;
                        if (!string.IsNullOrEmpty(roleName))
                        {
                            IdentityResult roleResult = await _userManager.AddToRoleAsync(user, roleName);
                            return RedirectToAction("Index", "Login");
                        }
                        return View();
                    }
                    return View();
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult RegisterCompany()
        {
            List<SelectListItem> cityvalues = (from x in _cityManager.TGetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.CityID.ToString()

                                               }).ToList();
            ViewBag.citylist = cityvalues;

            return View();
        }
        [HttpPost]
        public IActionResult RegisterCompany(Company p)
        {
            var username = User.Identity.Name;
            var ıd = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
            var name = c.Users.Where(x => x.UserName == username).Select(y => y.UserName).FirstOrDefault();
            var ımageurl = c.Users.Where(x => x.UserName == username).Select(y => y.ImageUrl).FirstOrDefault();
            
            CompanyValidator validationRules = new CompanyValidator();
            ValidationResult validationResult = validationRules.Validate(p);
            if (validationResult.IsValid)
            {    
                p.AppUserId = ıd;
                p.Name = name;
                p.ImageUrl = ımageurl;
                _companyManager.TAdd(p);
                return RedirectToAction("Index", "DashBoard");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}


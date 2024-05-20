using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsWebSitesi.Controllers
{
    public class CompanyController : Controller
    {
        CompanyManager _companyManager = new CompanyManager(new EfCompanyRepository());
        CityManager _cityManager = new CityManager(new EfCityRepository());
        Context c = new Context();
        private readonly UserManager<AppUser> _userManager;

        public CompanyController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            var values = _companyManager.TGetCompanyListWithCityandUser();
            return View(values);
        }
        [AllowAnonymous]
        public IActionResult CompanyDetails(int id)
        {
            ViewBag.i = id;
            var values = _companyManager.TGetCompanyByID(id);
            return View(values);
        }
        public IActionResult Index1()
        {
            var usermail = User.Identity.Name;
            ViewBag.v = usermail;
            var companyName = c.Companies.Where(x => x.AppUser.Email == usermail).Select(y => y.Name).FirstOrDefault();
            ViewBag.v2 = companyName;
            return View();
        }

        [HttpGet]
        public IActionResult CompanyEditProfile()
        {
            List<SelectListItem> cityvalues = (from x in _cityManager.TGetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.CityID.ToString()

                                               }).ToList();
            ViewBag.citylist = cityvalues;

            var username = User.Identity.Name;
            var mail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            ViewBag.mail = mail;
            var ıd = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
            var companyID = c.Companies.Where(x => x.AppUserId == ıd).Select(y => y.CompanyID).FirstOrDefault();
            var values = _companyManager.TGetByID(companyID);
            return View(values);

        }
        [HttpPost]
        public IActionResult CompanyEditProfile(Company p)
        {
            var username = User.Identity.Name;
            var ıd = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
            CompanyValidator validationRules = new CompanyValidator();
            ValidationResult validationResult = validationRules.Validate(p);
            if (validationResult.IsValid)
            {
                p.CityID = 1;
                p.AppUserId = ıd;
                _companyManager.TUpdate(p);
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

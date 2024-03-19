using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsWebSitesi.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        CompanyManager cm = new CompanyManager(new EfCompanyRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Company e)
        {
            CompanyValidator cv = new CompanyValidator();
            ValidationResult result = cv.Validate(e);
            if (result.IsValid)
            {
                e.CityID = 2;
                cm.TAdd(e);
                return RedirectToAction("Index", "AnaSayfa");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        } 
        
  
    }
}

using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsWebSitesi.Controllers
{
    public class AdvertsController : Controller
    {
        AdvertManager _advertManager = new AdvertManager(new EfAdvertRepository());
       
        public IActionResult Index()
        {
            var values = _advertManager.GetAdvertListWithCategoryCompany();
            return PartialView(values);
        }
        public IActionResult AdvertsDetail(int id)
        {
            ViewBag.i = id;
            var values = _advertManager.GetAdvertByID(id);
            return View(values);
        }  
        public IActionResult AdvertListByCompany()
        {
           var values= _advertManager.GetAdvertListByCompany(1);
            return View(values);
        }
        [HttpGet]
        public IActionResult AdvertAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdvertAdd(Advert p)
        {
            AdvertValidator av = new AdvertValidator();
            ValidationResult validationResult= av.Validate(p);
            if (validationResult.IsValid)
            {
                p.CompanyID = 1;
                p.CategoryID = 1;
                p.PostedDate = DateTime.Now;
                _advertManager.TAdd(p);
                return RedirectToAction("AdvertListByCompany", "Adverts");
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

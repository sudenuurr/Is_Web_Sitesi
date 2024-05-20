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
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
using X.PagedList.Mvc;

namespace IsWebSitesi.Controllers
{
    public class AdvertsController : Controller
    {
        AdvertManager _advertManager = new AdvertManager(new EfAdvertRepository());
        CategoryManager _categoryManager = new CategoryManager(new EfCategoryRepository());
        CityManager _cityManager = new CityManager(new EfCityRepository());
        ApplicationManager _applicationManager = new ApplicationManager(new EfApplicationRepository());
        private readonly UserManager<AppUser> _userManager;
        Context c = new Context();
        public AdvertsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            var values = _advertManager.GetAdvertListWithCategoryCompany();
            return View();
        }
        [AllowAnonymous]
        [HttpPost]   
        public IActionResult Index(int? categoryId, string? jobType, int? cityId, string? postedDate)
        {
            var categories = _categoryManager.TGetList();
            var cities = _cityManager.TGetList();
            var values = _advertManager.AdvertFilterList(categoryId, jobType, cityId, postedDate);

            // View'e verileri gönder
            return View(new FilterViewModel
            {
                Categories = categories,
                Cities = cities,
                Adverts = values
            });
        }

        [AllowAnonymous]
        public IActionResult AdvertsDetail(int id)
        {
            var companyıd= c.Adverts.Where(x => x.AdvertID == id).Select(y => y.CompanyID).FirstOrDefault();
            var image= c.Companies.Where(x => x.CompanyID == companyıd).Select(y => y.ImageUrl).FirstOrDefault();
            ViewBag.image = image;
            ViewBag.i = id;
            var values = _advertManager.GetAdvertByID(id);
            return View(values);
        }
        public IActionResult AdvertListByCompany(int page = 1)
        {

            var username = User.Identity.Name;
            var ıd = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
            var companyID = c.Companies.Where(x => x.AppUserId == ıd).Select(y => y.CompanyID).FirstOrDefault();
            var values = _advertManager.CategoryListByCompany(companyID).ToPagedList(page, 5);
            return View(values);

        }
        [HttpGet]
        public IActionResult AdvertAdd()
        {
            List<SelectListItem> categoryvalues = (from x in _categoryManager.TGetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.CategoryID.ToString()

                                                   }).ToList();
            ViewBag.cv = categoryvalues;
            return View();

        }
        [HttpPost]
        public IActionResult AdvertAdd(Advert p)
        {
            var username = User.Identity.Name;
            var ıd = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
            var companyID = c.Companies.Where(x => x.AppUserId == ıd).Select(y => y.CompanyID).FirstOrDefault();
            AdvertValidator av = new AdvertValidator();
            ValidationResult validationResult = av.Validate(p);
            if (validationResult.IsValid)
            {
                p.CompanyID = companyID;
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

        public IActionResult DeleteAdvert(int id)
        {
            var advertvalue = _advertManager.TGetByID(id);
            _advertManager.TDelete(advertvalue);
            return RedirectToAction("AdvertListByCompany", "Adverts");
        }
        [HttpGet]
        public IActionResult AdvertEdit(int id)
        {
            var advertvalue = _advertManager.TGetByID(id);
            List<SelectListItem> categoryvalues = (from x in _categoryManager.TGetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.CategoryID.ToString()

                                                   }).ToList();
            ViewBag.aa = categoryvalues;
            return View(advertvalue);
        }
        [HttpPost]
        public IActionResult AdvertEdit(Advert p)
        {
            _advertManager.TUpdate(p);
            return RedirectToAction("AdvertListByCompany");
        }

        public IActionResult AdvertApplication(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                var advertID = id;
                var username = User.Identity.Name;
                var userid = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
                Application application = new Application
                {
                    AdvertID = advertID,
                    AppUserId = userid,
                    Status = "Başvuru Yapıldı. Onay Bekleniyor",
                    ApplicationDate = DateTime.Now
                };
                c.Applications.Add(application);
                c.SaveChanges();
                return RedirectToAction("Index", "Adverts");

            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public IActionResult AdvertWithApplicationList(int id)
        {
            var values = _applicationManager.TGetListApplicationWithAdvert(id);
            return View(values);
        }

    }
}

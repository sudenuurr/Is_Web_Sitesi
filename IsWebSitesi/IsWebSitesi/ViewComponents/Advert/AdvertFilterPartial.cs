using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using IsWebSitesi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsWebSitesi.ViewComponents.Advert
{
    public class AdvertFilterPartial : ViewComponent
    {
        AdvertManager _advertManager = new AdvertManager(new EfAdvertRepository());
        CategoryManager _categoryManager = new CategoryManager(new EfCategoryRepository());
        CityManager _cityManager = new CityManager(new EfCityRepository());
        public IViewComponentResult Invoke()
        {
            var categories = _categoryManager.TGetList();
            var cities = _cityManager.TGetList();
            var adverts = _advertManager.TGetList();

            return View(new FilterViewModel
            {
                Categories = categories,
                Cities = cities,
                Adverts = adverts
            });
        }
    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsWebSitesi.ViewComponents.Advert
{
    public class CategoryListWithAdvert:ViewComponent
    {
        AdvertManager am = new AdvertManager(new EfAdvertRepository());
        public IViewComponentResult Invoke()
        {
            var values = am.GetAdvertListWithCategoryCompany().Where(a => a.AdvertID == ViewBag.i).ToList();
            return View(values);
        }
    }
}

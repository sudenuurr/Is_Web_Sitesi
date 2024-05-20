using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsWebSitesi.ViewComponents.Advert
{
    public class AdvertLast5:ViewComponent
    {
        AdvertManager _advertManager = new AdvertManager(new EfAdvertRepository());
        public IViewComponentResult Invoke()
        {
            var values = _advertManager.GetAdvertListWithCategoryCompany().Take(3).ToList();
            return View(values);
        }
    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace IsWebSitesi.ViewComponents.Advert
{
    public class AdvertContent: ViewComponent
    {
        AdvertManager _advertManager = new AdvertManager(new EfAdvertRepository());
        public IViewComponentResult Invoke()
        {
            var values = _advertManager.GetAdvertListWithCategoryCompany();
            return View(values);
        }
    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsWebSitesi.ViewComponents.City
{
    public class CityList:ViewComponent
    {
        CityManager cm = new CityManager(new EfCityRepository());

        public IViewComponentResult Invoke()
        {
            var values = cm.TGetList();
            return View(values);
        }
    }
}

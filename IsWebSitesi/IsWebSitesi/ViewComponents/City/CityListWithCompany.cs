using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsWebSitesi.ViewComponents.City
{
    public class CityListWithCompany:ViewComponent
    {
        CompanyManager cm = new CompanyManager(new EfCompanyRepository());
        public IViewComponentResult Invoke()
        {
            var values = cm.TGetCompanyListWithCityandUser().Where(a => a.CompanyID == ViewBag.i).ToList();
            return View(values);
        }
    }
}

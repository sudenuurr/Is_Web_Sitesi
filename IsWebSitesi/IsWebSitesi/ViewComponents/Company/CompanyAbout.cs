using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsWebSitesi.ViewComponents.Company
{
    public class CompanyAbout:ViewComponent
    {
        CompanyManager cm = new CompanyManager(new EfCompanyRepository());
        Context c = new Context();
        public IViewComponentResult Invoke(int id)
        {
            var company = c.Adverts.Where(x => x.AdvertID == id).Select(y => y.CompanyID).FirstOrDefault();
            var userıd = c.Companies.Where(x => x.CompanyID == company).Select(y => y.AppUserId).FirstOrDefault();
            var mail = c.Users.Where(x => x.Id == userıd).Select(y => y.Email).FirstOrDefault();

            ViewBag.mail = mail;

            var values = cm.GetList().Where(a => a.CompanyID == id).ToList() ;
            return View(values);
        }
    }
}

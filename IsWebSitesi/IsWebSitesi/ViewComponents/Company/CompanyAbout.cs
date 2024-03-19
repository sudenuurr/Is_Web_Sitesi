using BusinessLayer.Concrete;
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
        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetList().Where(a => a.CompanyID == id).ToList(); ;
            return View(values);
        }
    }
}

using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsWebSitesi.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var ıd = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
            var companyID = c.Companies.Where(x => x.AppUserId == ıd).Select(y => y.CompanyID).FirstOrDefault();

            ViewBag.v1 = c.Adverts.Count().ToString();
            ViewBag.v2 = c.Adverts.Where(x=>x.CompanyID==companyID).Count().ToString();
            ViewBag.v3 = c.Categories.Count().ToString();
            ViewBag.v4 = c.Companies.Count().ToString();

            return View();
        }
    }
}

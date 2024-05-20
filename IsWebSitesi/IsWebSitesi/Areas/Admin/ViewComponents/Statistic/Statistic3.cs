using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsWebSitesi.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic3:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var username = User.Identity.Name;
            var ıd = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
            ViewBag.v1 = c.Users.Where(x => x.Id ==ıd ).Select
                (y => y.UserName).FirstOrDefault();
            ViewBag.v2 = c.Users.Where(x => x.Id == ıd).Select
                 (y => y.ImageUrl).FirstOrDefault();
            ViewBag.v2 = c.Users.Where(x => x.Id == ıd).Select
                 (y => y.Email).FirstOrDefault();
            return View();
        }
    }
}

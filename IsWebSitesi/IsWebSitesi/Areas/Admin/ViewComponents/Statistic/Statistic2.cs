using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsWebSitesi.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic2:ViewComponent
    {
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Adverts.OrderByDescending(x => x.AdvertID).Select(x => x.Department).Take(1).FirstOrDefault();
            return View();
        }
    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsWebSitesi.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic4 : ViewComponent
    {
        Message2Manager _message2Manager = new Message2Manager(new EfMessage2Repository());
        public IViewComponentResult Invoke()
        {
            var values = _message2Manager.TGetListMessageAppUser().Take(4).ToList();
            return View(values);
        }
    }
}

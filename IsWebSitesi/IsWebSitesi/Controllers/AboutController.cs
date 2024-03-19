using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsWebSitesi.Controllers
{
    public class AboutController : Controller
    {
        AboutManager am = new AboutManager(new EfAboutRepository());
        [AllowAnonymous]
        public IActionResult Index()
        {
            var values = am.TGetList();
            return View(values);
        }
    }
}

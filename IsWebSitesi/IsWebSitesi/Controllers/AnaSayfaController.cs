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
    public class AnaSayfaController : Controller
    {
        AdvertManager am = new AdvertManager(new EfAdvertRepository());
        [AllowAnonymous]
        public IActionResult Index()
        {
            var values = am.GetAdvertListWithCategoryCompany();
            return View(values);
        }
    }
}

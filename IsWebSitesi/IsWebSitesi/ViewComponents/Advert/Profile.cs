using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsWebSitesi.ViewComponents.Advert
{
    public class Profile:ViewComponent
    {
        UserManager _userManager = new UserManager(new EfUserRepository());

        public IViewComponentResult Invoke(int id)
        {
            var values = _userManager.TGetByID(id);
            return View(values);
        }
    }
}

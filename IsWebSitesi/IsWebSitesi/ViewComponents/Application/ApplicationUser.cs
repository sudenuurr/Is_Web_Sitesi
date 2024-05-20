using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsWebSitesi.ViewComponents.Application
{
    public class ApplicationUser:ViewComponent
    {

        ApplicationManager _applicationManager = new ApplicationManager(new EfApplicationRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = _applicationManager.TGetListApplicationDetail(id);
            return View(values);
        }
    }
}

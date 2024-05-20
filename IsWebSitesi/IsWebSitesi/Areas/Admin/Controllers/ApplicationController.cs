using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace IsWebSitesi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ApplicationController : Controller
    {
        ApplicationManager _applicationManager = new ApplicationManager(new EfApplicationRepository());
        Context c = new Context();
        public IActionResult Index(int page = 1)
        {
            var values = _applicationManager.TGetListApplicationAppUserandAdvert().ToPagedList(page, 10);
            return View(values);
        }
        public IActionResult DeleteApplication(int id)
        {
            var value = _applicationManager.TGetByID(id);
            _applicationManager.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}

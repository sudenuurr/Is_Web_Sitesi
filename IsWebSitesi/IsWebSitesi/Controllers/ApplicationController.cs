using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsWebSitesi.Controllers
{
    public class ApplicationController : Controller
    {
        ApplicationManager _applicationManager = new ApplicationManager(new EfApplicationRepository());
        Context c = new Context();
        public IActionResult Index()
        {
            var username = User.Identity.Name;
            var ıd = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
            var values = _applicationManager.TGetListApplicationWithUser(ıd);
            return View(values);
        }
        [HttpGet]
        public IActionResult ApplicationEdit(int id)
        {
            ViewBag.StatusList = new List<SelectListItem>
            {
                new SelectListItem { Text = "Başvurunuz Onaylandı", Value = "Başvurunuz Onaylandı" },
                new SelectListItem { Text = "Başvuru Yapıldı. Onay Bekleniyor", Value = "Başvuru Yapıldı. Onay Bekleniyor" },
                new SelectListItem { Text = "Başvurunuz Kabul Edilmedi.", Value = "Başvurunuz Kabul Edilmedi" }
            };
            var value = _applicationManager.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult ApplicationEdit(Application p)
        {
            _applicationManager.TUpdate(p);
            return RedirectToAction("Index");
        }

    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsWebSitesi.Areas.Member.Controllers
{
    [Area("Member")]
    public class MyApplication : Controller
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
        public IActionResult ApprovalAdvert()
        {
            var username = User.Identity.Name;
            var ıd = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
            var values = _applicationManager.TGetListApplicationWithUserApproval(ıd);
            return View(values);
        }
        public IActionResult RejectedAdvert()
        {
            var username = User.Identity.Name;
            var ıd = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
            var values = _applicationManager.TGetListApplicationWithUserRejected(ıd);
            return View(values);
        }
        public IActionResult WaitAdvert()
        {
            var username = User.Identity.Name;
            var ıd = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
            var values = _applicationManager.TGetListApplicationWithUserByWaitApproval(ıd);
            return View(values);
        }
    }
}

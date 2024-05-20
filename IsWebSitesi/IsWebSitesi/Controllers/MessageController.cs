using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsWebSitesi.Controllers
{
    public class MessageController : Controller
    {
        Message2Manager _message2Manager = new Message2Manager(new EfMessage2Repository());
        UserManager _userManager = new UserManager(new EfUserRepository());
        Context c = new Context();
        public IActionResult InBox()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var id = c.Users.Where(x => x.Email == usermail)
                .Select(y => y.Id).FirstOrDefault();
            var values = _message2Manager.TGetInboxListByAppUser(id);
            return View(values);
        }
        public IActionResult MessageDetails(int id)
        {
            var value = _message2Manager.TGetByID(id);
            return View(value);
        }
        [HttpGet]
        public IActionResult AddMessage()
        {
            List<SelectListItem> uservalues = (from x in _userManager.TGetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.UserName,
                                                       Value = x.Id.ToString()

                                                   }).ToList();
            ViewBag.uv = uservalues;
            return View();
        }
        [HttpPost]
        public IActionResult AddMessage(Message2 p)
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var id = c.Users.Where(x => x.Email == usermail)
                .Select(y => y.Id).FirstOrDefault();
            MessageValidator validationRules = new MessageValidator();
            ValidationResult validationResult = validationRules.Validate(p);
            if (validationResult.IsValid)
            {
                p.SenderID = id;
                p.Status = true;
                p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                _message2Manager.TAdd(p);
                return RedirectToAction("InBox");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}


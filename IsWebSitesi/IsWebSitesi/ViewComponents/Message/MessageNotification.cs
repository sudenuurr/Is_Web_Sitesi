using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsWebSitesi.ViewComponents.Message
{
    public class MessageNotification:ViewComponent
    {
        Message2Manager message2Manager = new Message2Manager(new EfMessage2Repository());
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var id = c.Users.Where(x => x.Email == usermail)
                .Select(y => y.Id).FirstOrDefault();
            var values = message2Manager.TGetInboxListByAppUser(id).Take(3).ToList();
            return View(values);
        }
    }
}

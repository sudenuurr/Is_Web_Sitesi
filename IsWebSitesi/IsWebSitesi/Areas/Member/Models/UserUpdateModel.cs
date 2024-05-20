using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsWebSitesi.Areas.Member.Models
{
    public class UserUpdateModel
    {
        public string namesurname { get; set; }
        public string username { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public string imageurl { get; set; }
        public bool ChangePassword { get; set; }
    }
}

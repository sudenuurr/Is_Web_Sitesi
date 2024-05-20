using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public AppUser()
        {
            this.Companies = new HashSet<Company>();
        }
        public string NameSurname { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Company> Companies { get; set; }
        public virtual ICollection<Message2> AppUserSender { get; set; }
        public virtual ICollection<Message2> AppUserReceiver { get; set; }
        public List<Application> Applications { get; set; }

    }
}

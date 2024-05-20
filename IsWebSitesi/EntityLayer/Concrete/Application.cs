using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Application
    {
        [Key]
        public int ApplicationID { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int AdvertID { get; set; }
        public Advert Advert { get; set; }
        public string Status { get; set; }
        public DateTime ApplicationDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Company
    {
        [Key]
        public int CompanyID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ImageUrl { get; set; }
        public List<Advert> Adverts { get; set; }
        public int CityID { get; set; }
        public City City { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}

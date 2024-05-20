using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Advert
    {
        [Key]
        public int AdvertID { get; set; }
        public string Department { get; set; }
        public string JobType { get; set; }
        public string Description { get; set; }
        public string Required { get; set; }
        public string Experience { get; set; }
        public DateTime PostedDate { get; set; }
        public DateTime ApplicationDeadline { get; set; }
        public int CompanyID { get; set; }
        public Company Company { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public List<Application> Applications { get; set; }

    }
}

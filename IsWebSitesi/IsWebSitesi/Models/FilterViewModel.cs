using EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace IsWebSitesi.Models
{
    public class FilterViewModel
    {
        public int? CategoryID { get; set; }
        public List<Category> Categories { get; set; }
        public int? CityID { get; set; }
        public List<City> Cities { get; set; }
        public List<Advert> Adverts { get; set; }
        public string? JobType { get; set; }
        public DateTime? PostedDate { get; set; }
    }
}

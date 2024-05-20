using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsWebSitesi.Areas.Admin.Models
{
    public class AdvertModel
    {
        public int ID { get; set; }
        public string Departman { get; set; }
        public string CalismaTuru { get; set; }
        public string Aciklama { get; set; }
        public string Gereklilikler { get; set; }
        public string Deneyim { get; set; }
    }
}
